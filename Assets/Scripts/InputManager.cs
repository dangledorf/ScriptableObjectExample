using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameEventSystem;

public class InputManager : MonoBehaviour {
	[SerializeField] private GameEvent inputJump;

	void FixedUpdate()
	{
		// Primary Fire input
		if(Input.GetButtonDown("Jump"))
			inputJump.Raise();
	}
}
