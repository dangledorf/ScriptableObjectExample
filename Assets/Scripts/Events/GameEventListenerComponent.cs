using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameEventSystem
{
	[System.Serializable]
	public class GameEventListenerComponent : MonoBehaviour {
		[SerializeField] private List<GameEventListener> gameEvents = new List<GameEventListener>();

		public void OnEnable()
		{
			foreach(GameEventListener gameEvent in gameEvents)
				gameEvent.Event.RegisterListener(gameEvent);
		}

		public void OnDisable()
		{
			foreach(GameEventListener gameEvent in gameEvents)
				gameEvent.Event.UnregisterListener(gameEvent);
		}
	}
}