using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScriptableIntegerToTMP : ScriptableVariableToTMP
{
	[SerializeField] private ScriptableInt variable;

	public override void OnUpdateText()
	{
		tmp.text = variable.Value.ToString();
	}
}
