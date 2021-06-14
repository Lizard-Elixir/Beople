using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class BirdController : MonoBehaviour
{
	CharacterController characterController;
	public GameObject player;
	private ThirdPersonMovement movementScript;
	Vector3 destination;
	NavMeshAgent agent;

	public bool IsRecruited = false;
	[SerializeField] private float playerBufferDistance = 6.0f;

	[SerializeField] private VarObject recruitedBeopleVar;
	[SerializeField] ParticleSystem collectParticles;
	[SerializeField] private BirdLeaderController leader;

	void Awake() => characterController = GetComponent<CharacterController>();

	void Start()
	{
		agent = GetComponent<NavMeshAgent>();
		destination = agent.destination;
		player = GameObject.FindWithTag("Player");
		movementScript = player.GetComponent<ThirdPersonMovement>();
	}

	// Update is called once per frame
	void Update()
	{
		if (IsRecruited)
		{
			MoveTowardsPlayer();
		}
	}

	public bool Recruit()
	{
		if (IsRecruited || (!!leader && !leader.IsRecruited))
		{
			return false;
		}

		IsRecruited = true;
		recruitedBeopleVar.currentNum += 1;
		collectParticles.Play();

		// Allow the player to pass through recruited beople
		Collider playerCollider = player.GetComponent<Collider>();
		Collider bersonCollider = GetComponent<Collider>();
		Physics.IgnoreCollision(bersonCollider, playerCollider);

		Debug.Log("Recruited Berson!");
		Debug.Log(recruitedBeopleVar.currentNum);
		return true;
	}

	public void MoveTowardsPlayer()
	{
		float distanceFromPlayer = Vector3.Distance(transform.position, player.transform.position);
		bool isFarEnoughFromPlayer = distanceFromPlayer > playerBufferDistance;
		if (isFarEnoughFromPlayer)
		{
			float distanceFromPreviousDestination = Vector3.Distance(destination, player.transform.position);
			bool destionationHasChanged = distanceFromPreviousDestination > 1.0f;
			if (destionationHasChanged)
			{
				destination = player.transform.position;
			}
		}
		else
		{
			destination = transform.position;
		}

		agent.destination = destination;
	}
}
