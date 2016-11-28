using UnityEngine;
using System.Collections;

public class Exit : MonoBehaviour {

	void OnMouseDown() {
		if(Input.GetMouseButtonDown(0)){
			Debug.Log ("Adios");
			Application.Quit();

		}
}
}
