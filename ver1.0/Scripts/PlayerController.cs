using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Vector3 MousePos; //MousePosition
    private Vector3 CuePos;  //PlayerBallPosition
    private float ForceX;  //PushDirection
    private float ForceY;
    private Rigidbody rb;
    private GameObject cue;
    private GameObject Manneger;
    private MainGame maingame;

    public int exist;

    void Start () {
        rb = GetComponent<Rigidbody>();
        cue = (GameObject)Resources.Load("cue ball");
        Manneger=GameObject.Find("Manneger");
        maingame = Manneger.GetComponent<MainGame>();
    }

    void FixedUpdate() {
        exist = GameObject.FindGameObjectsWithTag("solers").Length;
        if (Input.GetMouseButtonDown(0))
        {
            CuePos = Input.mousePosition;
        }

        if (Input.GetMouseButton(0))
        {
            MousePos = Input.mousePosition;
        }

        //引っ張ってシュート
        if (Input.GetMouseButtonUp(0))
        {
                ForceX = CuePos.x - MousePos.x;
                ForceY = CuePos.y - MousePos.y;
                //Debug.Log(ForceX + " : 0 : " + ForceY);
                rb.AddForce(ForceX / (float)2.5, 0, ForceY / (float)2.5, ForceMode.Impulse);
                if (exist > 0){
                    maingame.count++;
                }
        }

        //落ちたら
        if (rb.position.y < -5)
        {
            Destroy(this.gameObject);
            Instantiate(cue, new Vector3(-2f, 3f, 0f), Quaternion.identity);
            if (exist > 0){
                maingame.drop++;
            }
        }
    }
}
