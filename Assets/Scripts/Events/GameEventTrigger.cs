using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameEventSystem
{
	[System.Serializable]
	public class GameEventTrigger : MonoBehaviour {
		[SerializeField] private GameEvent onTrigger;

		public void OnTrigger()
		{
			onTrigger.Raise();
		}
	}
}