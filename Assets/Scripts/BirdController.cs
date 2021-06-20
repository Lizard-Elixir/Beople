using UnityEngine;
using UnityEngine.AI;
using UnityAtoms.BaseAtoms;

[RequireComponent(typeof(NavMeshAgent))]
public class BirdController : MonoBehaviour
{
	public bool IsRecruited = false;
	public NavMeshAgent agent;
	[SerializeField] ParticleSystem collectParticles;
	[SerializeField] GameObjectValueList RecruitedBeople;

	protected GameObject player;

	[SerializeField] private float playerBufferDistance = 6.0f;
	[SerializeField] private BirdLeaderController leader;
	private CharacterController characterController;
	private ThirdPersonMovement movementScript;
	private Vector3 destination;

	void Awake() => characterController = GetComponent<CharacterController>();

	protected void Start()
	{
		agent = GetComponent<NavMeshAgent>();
		destination = agent.destination;
		player = GameObject.FindWithTag("Player");
		movementScript = player.GetComponent<ThirdPersonMovement>();

		// Set initial movement speed to match player movement speed
		agent.speed = movementScript.speed;
	}

	// Update is called once per frame
	protected void Update()
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

		RecruitedBeople.Add(gameObject);
		collectParticles.Play();

		// Allow the player to pass through recruited beople
		Collider playerCollider = player.GetComponent<Collider>();
		Collider bersonCollider = GetComponent<Collider>();
		Physics.IgnoreCollision(bersonCollider, playerCollider);

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
