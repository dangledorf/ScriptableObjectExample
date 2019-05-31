using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Float", menuName = "Scriptable Variables/Float", order = 0)]
public class ScriptableFloat : ScriptableVariable {
	[SerializeField] private float InitialValue = 0f;
	public float CurrentValue = 0f;
	public float Value
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
