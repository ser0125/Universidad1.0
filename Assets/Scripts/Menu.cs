using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Menu : MonoBehaviour {

	public GameObject mainMenuHolder;
	public GameObject mainOptionHolder;

	public AudioSource audioSourcebutton;

	public Slider[] volumeSliders;

	void Start(){



		// get the float value of SliderVolumeLevel if it has been saved with PlayerPrefs.SetFloat()
		// else use defult value of audioSource.volume
		audioSourcebutton.volume = PlayerPrefs.GetFloat("SliderSfxVolume", audioSourcebutton.volume);
		Camera.main.GetComponent < AudioSource >().volume= PlayerPrefs.GetFloat ("SliderMusicVolume", Camera.main.GetComponent<AudioSource>().volume);
	}

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

		Camera.main.GetComponent<AudioSource> ().volume = value;
		PlayerPrefs.SetFloat("SliderMusicVolume", value);
	}
	public void SetSfxVolume(float value){
		audioSourcebutton.volume = value;
		PlayerPrefs.SetFloat("SliderSfxVolume", value);
	}
}
