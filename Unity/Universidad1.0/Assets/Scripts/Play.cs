using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour {

	 void OnMouseDown() {
		if(Input.GetMouseButtonDown(0)){
			SceneManager.LoadScene ("Game");
		}
	}

}
