using UnityEngine;
using System.Collections;

public class NpcDialogue : MonoBehaviour {

	public string[] answers;
	public string[] Questions;
	bool displayDialogue=false;
	public GameObject character1;
	bool isClicked;

	void OnTriggerEnter(){
		displayDialogue = true;
	

	}

	void OnTriggerExit(){
		displayDialogue = false;
	}

	void OnGUI(){

		GUILayout.BeginHorizontal(); 
		bool isHorizontalBlockActive = true; 
		if (displayDialogue) {
			
			GUILayout.Label ( Questions [0]);
			GUILayout.Label ( Questions [1]);

			isClicked=GUILayout.Button (answers [0]);
	
			if (isClicked) {
				Debug.Log ("aquii");
				Invoke ("WaitToEnd",5f);
	
			}
			GUILayout.Button ( answers [1]);
			isHorizontalBlockActive = false;     

			displayDialogue = false;
			if(isHorizontalBlockActive)
				GUILayout.EndHorizontal();
			
	
	}



}
}
