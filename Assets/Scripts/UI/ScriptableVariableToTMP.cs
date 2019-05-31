using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScriptableVariableToTMP : MonoBehaviour
{
	[SerializeField] protected TextMeshProUGUI tmp;

	void Start()
	{
		if(tmp == null)
		{
			tmp = GetComponent<TextMeshProUGUI>();
		}
	}

	void OnEnable()
	{
		OnUpdateText();
	}

	public virtual void OnUpdateText()
	{
		// Update UI
	}
}
