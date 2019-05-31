using UnityEditor;
using UnityEngine;

namespace GameEventSystem
{
	[CustomEditor(typeof(GameEvent))]
	public class GameEventEditor : Editor {
		public override void OnInspectorGUI()
		{
			DrawDefaultInspector();
	        
	        GameEvent myScript = (GameEvent)target;
	        if(GUILayout.Button("Raise Event"))
	        {
	            myScript.Raise();
	        }
		}
	}
}
