using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MoveTitle : MonoBehaviour {
    //TitleSceneへ移動
    public void OnClick(){
        SceneManager.LoadScene("Title");
    }
}