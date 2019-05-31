using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapManager : MonoBehaviour
{
	[SerializeField] private ScriptableInt tapTotal;

    public void OnTap()
    {
    	tapTotal.Value ++;
    }
}
