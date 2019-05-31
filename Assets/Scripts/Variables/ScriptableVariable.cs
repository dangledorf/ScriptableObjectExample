using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameEventSystem;

public class ScriptableVariable : ScriptableObject, ISerializationCallbackReceiver {
	[SerializeField] private bool persistentVariable = false;
	[SerializeField] private GameEvent onVariableChanged = null;

	// Calls to reset the variable to default
	protected virtual void ResetVariable() {}

	// Resets the Scriptable Variable on reload
	public void OnAfterDeserialize()
	{
		if(persistentVariable) return;
		ResetVariable();
	}

	public void OnBeforeSerialize() {}

	public void OnValidate()
	{
		if(onVariableChanged == null) return;	
		onVariableChanged.Raise();
	}
}
