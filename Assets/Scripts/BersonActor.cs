using UnityEngine;
using UnityEditor;
using System.Collections;

namespace EightDirectionalSpriteSystem
{
	[ExecuteInEditMode]
	public class BersonActor : MonoBehaviour
	{
		public enum State { NONE, IDLE };

		public ActorBillboard actorBillboard;

		public ActorAnimation idleAnim;

		private Transform myTransform;
		private ActorAnimation currentAnimation = null;
		private State currentState = State.NONE;

		void Awake()
		{
			myTransform = GetComponent<Transform>();
		}

		void Start()
		{
			SetCurrentState(State.IDLE);
		}

		private void OnEnable()
		{
			SetCurrentState(State.IDLE);
		}

		private void OnValidate()
		{
			if (actorBillboard != null && actorBillboard.CurrentAnimation == null)
				SetCurrentState(currentState);
		}

		void Update()
		{
			if (actorBillboard != null)
			{
				actorBillboard.SetActorForwardVector(myTransform.forward);
			}
		}

		private void SetCurrentState(State newState)
		{
			currentState = newState;
			switch (currentState)
			{
				default:
					currentAnimation = idleAnim;
					break;
			}

			if (actorBillboard != null)
			{
				actorBillboard.PlayAnimation(currentAnimation);
			}
		}

	}
}
