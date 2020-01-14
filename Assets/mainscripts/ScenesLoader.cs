using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesLoader : MonoBehaviour
{
	public void LoadScene(int sceneNumber)
	{
		load.sceneID = sceneNumber;
		SceneManager.LoadScene(2);
	}
}
