using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

	// Load Scene 01 when start button is pressed
	public void StartGame()
	{
		StartCoroutine (DelayStartGame ());
		//SceneManager.LoadScene ("SceneChoose");
	}

	// Load Trophy Room scene when trophy room button is pressed
	public void GotoTrophyRoom()
	{
		StartCoroutine (DelayTrophy ());
		//SceneManager.LoadScene ("TrophyRoom");
	}

	// Reset All Player Preferences data to start earn trophies again
	public void ResetPlayerPrefs()
	{
		//StartCoroutine (DelaySceneLoad ());
		PlayerPrefs.DeleteAll ();
	}

	IEnumerator DelayStartGame ()
	{
		yield return new WaitForSeconds (0.2f);
		SceneManager.LoadScene ("SceneChoose");
	}

	IEnumerator DelayTrophy ()
	{
		yield return new WaitForSeconds (0.2f);
		SceneManager.LoadScene ("TrophyRoom");
	}
}
