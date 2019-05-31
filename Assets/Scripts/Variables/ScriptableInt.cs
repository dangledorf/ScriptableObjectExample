using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Int", menuName = "Scriptable Variables/Integer", order = 2)]
public class ScriptableInt : ScriptableVariable {
	[SerializeField] private int InitialValue = 0;
	public int CurrentValue = 0;
	public int Value
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
