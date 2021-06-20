using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityAtoms.BaseAtoms;

public class SquawkController : MonoBehaviour
{
	[SerializeField] GameObjectValueList RecruitedBeople;
	[SerializeField] private FloatVariable MoveSpeed;
	[SerializeField] private FloatVariable SquawkRadius;
	[SerializeField] private FloatVariable SquawkDuration;
	[SerializeField] private FloatVariable SquawkCooldown;

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
		SetSquawkRadius(SquawkRadius.Value);
	}

	// Update is called once per frame
	void Update()
	{
		if (Time.time - LastSquawkTime > SquawkDuration.Value)
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
		transform.localScale = new Vector3(SquawkRadius.Value * 2, transform.localScale.y, SquawkRadius.Value * 2);
	}

	/**
	 * Checks within a radius for recruitable NPCs.
	 * Then, calls a `.Recruit()` method on each of them and adds to them to the beeple recruited count. 
	 */
	public void Squawk()
	{
		if (Time.time - LastSquawkTime < SquawkCooldown.Value)
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
		RecruitedBeople.Add(berson);
		switch (berson.name)
		{
			case "ChickenLeader":
				SquawkCooldown.Value *= 0.75f;
				break;
			case "SparrowLeader":
				MoveSpeed.Value *= 2f;
				break;
			case "MagpieLeader":
				SquawkRadius.Value *= 1.5f;
				SetSquawkRadius(SquawkRadius.Value);
				break;
		}
	}
}
