using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonScript : MonoBehaviour {

	// Load Main Menu scene when Back Button is pressed
	public void BackToMainMenu()
	{
		StartCoroutine (DelaySceneLoad ());
		//SceneManager.LoadScene ("MainMenu");
	}

	IEnumerator DelaySceneLoad ()
	{
		yield return new WaitForSeconds (0.2f);
		SceneManager.LoadScene ("MainMenu");
	}
}
