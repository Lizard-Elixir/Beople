using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
	public Transform target;

	[SerializeField] private Vector3 offset;

	void Start()
	{
		offset = transform.position - target.position;
	}

	void LateUpdate()
	{
		//transform.LookAt(target);
		transform.position = target.position + offset;
	}
}
