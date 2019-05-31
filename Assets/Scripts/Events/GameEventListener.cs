using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace GameEventSystem
{
	[System.Serializable]
	public class GameEventListener {
		[SerializeField] private string Name = "";

		public GameEvent Event;
		public UnityEvent Response;

		public void OnEventRaised()
		{
			Response.Invoke();
		}
	}
}