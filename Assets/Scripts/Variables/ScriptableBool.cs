using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Boolean", menuName = "Scriptable Variables/Boolean", order = 1)]
public class ScriptableBool : ScriptableVariable {
	[SerializeField] private bool InitialValue = false;
	public bool CurrentValue = false;
	public bool Value
	{
		get { return CurrentValue; }
		set 
		{
			CurrentValue = value;
			OnValidate();
		}
	}

	protected override void ResetVariable() 
	{ 
		CurrentValue = InitialValue; 
	}
}
