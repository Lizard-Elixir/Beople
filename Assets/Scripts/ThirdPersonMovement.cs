using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EightDirectionalSpriteSystem;
using UnityAtoms.BaseAtoms;

public class ThirdPersonMovement : MonoBehaviour
{
	[SerializeField] StateObject state;
	[SerializeField] private BoolVariable Paused;
	[SerializeField] private BoolVariable PlayerIsTalking;
	public CharacterController controller;
	public float speed = 6f;

	private ActorBillboard Billboard;

	void Start()
	{
		Billboard = GetComponentInChildren<ActorBillboard>();
	}

	// Update is called once per frame
	void Update()
	{
		if (!PlayerIsTalking.Value && !Paused.Value)
		{
			float horizontal = Input.GetAxisRaw("Horizontal");
			float vertical = Input.GetAxisRaw("Vertical");
			Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

			if (direction.magnitude >= 0.1f)
			{
				float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
				transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);
				controller.Move(direction * speed * Time.deltaTime);
			}
		}
	}
}
