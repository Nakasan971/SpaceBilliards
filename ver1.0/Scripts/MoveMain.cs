using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveMain : MonoBehaviour
{
	//MaingameSceneへ移動
    void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
			SceneManager.LoadScene("Maingame");
		}
	}
}
