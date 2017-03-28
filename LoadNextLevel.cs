using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadNextLevel : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if (transform.childCount <= 0) {
		//keine Blöcke mehr
			int targetSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

			if (targetSceneIndex >= SceneManager.sceneCountInBuildSettings) {
			
				targetSceneIndex = 0;
			}
			Debug.Log (targetSceneIndex);
			SceneManager.LoadScene (targetSceneIndex);

		}
	}
}
