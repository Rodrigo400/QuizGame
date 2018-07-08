using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TopicChoice : MonoBehaviour {

	public string sceneName;

	public void ChangeScene(string sceneName)
	{
		//yield return new WaitForSeconds(0.5);
		//ExecuteAfterTime(1.5f);
		//SceneManager.LoadScene (sceneName);

		StartCoroutine(DelayTopic(sceneName));
	}

	public void ChangeWin(string sceneName) 
	{
		StartCoroutine (DelayWin (sceneName));
	}

	IEnumerator DelayTopic (string sceneName)
	{
		yield return new WaitForSeconds (0.2f);
		SceneManager.LoadScene (sceneName);
	}

	IEnumerator DelayWin (string sceneName)
	{
		yield return new WaitForSeconds (2.0f);
		SceneManager.LoadScene (sceneName);
	}
}
