using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SquawkController : MonoBehaviour
{
	public float SquawkRadius = 12.5f;
	public float SquawkDuration = 1f;
	public float SquawkCooldown = 2f;
	[SerializeField] StateObject state;

	private float LastSquawkTime;
	private MeshRenderer meshRenderer;
	private SphereCollider sphereCollider;

	// Start is called before the first frame update
	void Start()
	{
		meshRenderer = this.GetComponent<MeshRenderer>();
		meshRenderer.enabled = false;
		sphereCollider = this.GetComponent<SphereCollider>();
		sphereCollider.enabled = false;
		SetSquawkRadius(SquawkRadius);
	}

	// Update is called once per frame
	void Update()
	{
		if (Time.time - LastSquawkTime > SquawkDuration)
		{
			meshRenderer.enabled = false;
			sphereCollider.enabled = false;
		}
	}

	//Upon collision with another GameObject, this GameObject will reverse direction
	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Berson"))
		{
			other.GetComponent<BirdController>().Recruit();
			state.RecruitedBeople.Add(other.gameObject);
		}

		if (other.CompareTag("BersonLeader"))
		{
			BirdLeaderController leaderController = other.GetComponent<BirdLeaderController>();
			if (!leaderController.IsRecruited)
			{
				Input.ResetInputAxes();
				leaderController.TriggerDialogue();
				HandleLeaderRecruitment(other.gameObject);
				return;
			}
		}
	}

	public void SetSquawkRadius(float radius)
	{
		transform.localScale = new Vector3(SquawkRadius * 2, transform.localScale.y, SquawkRadius * 2);
	}

	/**
	 * Checks within a radius for recruitable NPCs.
	 * Then, calls a `.Recruit()` method on each of them and adds to them to the beeple recruited count. 
	 */
	public void Squawk()
	{
		if (Time.time - LastSquawkTime < SquawkCooldown)
		{
			return;
		}

		meshRenderer.enabled = true;
		sphereCollider.enabled = true;
		GetComponent<AudioSource>().Play();
		LastSquawkTime = Time.time;
	}

	void HandleLeaderRecruitment(GameObject berson)
	{
		state.RecruitedBeople.Add(berson);
		switch (berson.name)
		{
			case "ChickenLeader":
				SquawkCooldown *= 0.75f;
				break;
			case "SparrowLeader":
				ThirdPersonMovement movementScript = GetComponentInParent<ThirdPersonMovement>();
				movementScript.speed *= 2f;
				GameObject[] normalBersons = GameObject.FindGameObjectsWithTag("Berson");
				GameObject[] leaderBersons = GameObject.FindGameObjectsWithTag("BersonLeader");
				GameObject[] allBersons = normalBersons.Concat(leaderBersons).ToArray();
				foreach (GameObject b in allBersons)
				{
					BirdController birdScript = b.GetComponent<BirdController>();
					birdScript.agent.speed = movementScript.speed;
				}
				break;
			case "MagpieLeader":
				SetSquawkRadius(SquawkRadius *= 1.5f);
				break;
		}
	}
}
