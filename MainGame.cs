using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MainGame : MonoBehaviour {

    [SerializeField] GameObject score = GameObject.Find("score");//Pannel
	// Use this for initialization
    [SerializeField] Text scoreText = GameObject.Find("OOO").GetComponent<Text>();//Text
    public int count=0;//打数カウンター
    public int drop=0;//落下カウンター
    private int poket = 0;//得点 

    //白球＆惑星球生成
	void Start () {
        GameObject sol = (GameObject)Resources.Load("Soler");
        GameObject cue = (GameObject)Resources.Load("cue ball");
        Instantiate(sol, new Vector3(1f, 1f, 0f), Quaternion.identity);
        Instantiate(cue, new Vector3(-2f, 1f, 0f), Quaternion.identity);
        score.SetActive(false);//pannel非表示
    }

    //惑星球がなくなるまで
    void Update () {
        GameObject[] exist = GameObject.FindGameObjectsWithTag("solers");
        if (exist.Length==0)
        {
            poket = 10000 - ((count-9)*50+(drop*100));//得点書き換え

            scoreText.text = poket.ToString();//得点書き換え
            score.SetActive(true);//pannel表示
        }
	}
}