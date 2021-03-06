using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Menu : MonoBehaviour {

	public GameObject mainMenuHolder;
	public GameObject mainOptionHolder;

	public AudioSource audioSourcebutton;

	public Slider[] volumeSliders;


	public void MainMenu(){
		AudioSource audioSource = Camera.main.GetComponent<AudioSource>();
		audioSource.Stop ();
		audioSourcebutton.Play ();
		Invoke ("BackMusic",audioSourcebutton.clip.length);
		mainMenuHolder.SetActive(true);
		mainOptionHolder.SetActive(false);
	}
	public void OptionMenu(){

		AudioSource audioSource = Camera.main.GetComponent<AudioSource>();
		audioSource.Stop ();
		audioSourcebutton.Play ();
		Invoke ("BackMusic",audioSourcebutton.clip.length);
		mainMenuHolder.SetActive(false);
		mainOptionHolder.SetActive(true);

	}
public void Play () {

	
		AudioSource audioSource = Camera.main.GetComponent<AudioSource>();
		audioSource.Stop ();
		audioSourcebutton.Play ();
		Invoke ("WaitAudio",audioSourcebutton.clip.length);


	
	}
	void WaitAudio() {
		SceneManager.LoadScene ("Selection");
	}
	void BackMusic(){
		AudioSource audioSource = Camera.main.GetComponent<AudioSource>();
		audioSource.Play ();
	
	}
	

	public void Quit () {

	

		AudioSource audioSource = Camera.main.GetComponent<AudioSource>();
		audioSource.Stop ();
		audioSourcebutton.Play ();
		Application.Quit ();
	
	}

		
	

	public void SetMasterVolume(float value){

	}
	public void SetMusicVolume(float value){

	}
	public void SetSfxVolume(float value){

	}
}
