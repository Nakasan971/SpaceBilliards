using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class solerController : MonoBehaviour {

    public bool Moving = false;//動いているか？
    public bool pokets = false;//ポケットしたか？
    //前の位置
    private float Prex;
    private float Prez;
    //今の位置
    private float Crex;
    private float Crez;
    private Rigidbody rb;
    private Transform tr;
    private Vector3 pos;

    void Start () {
        rb = GetComponent<Rigidbody>();
        tr = this.transform;
        pos = tr.position;
        Prex = rb.position.x;
        Prez = rb.position.z;
    }

    //移動しているか
    void Update() {
        Crex = Prex;
        Crez = Prez;
        Prex = rb.position.x;
        Prez = rb.position.z;
        if (Crex != Prex || Crez != Prez)
        {
            Moving = true;
        }
        if(Crex == Prex || Crez == Prez)
        {
            Moving = false;
        }
        if (rb.position.y < -5)
        {
            //ポケットしたら
            if (-4.9 < rb.position.x && rb.position.x < 4.9
                && -2.9 < rb.position.z && rb.position.z < 2.9)
            {
                pokets = true;
                Destroy(this.gameObject);
            }
            //場外に落ちたら
            pos.x = Random.Range(-3, 3);
            pos.y = 1;
            pos.z = Random.Range(-1, 1);
            tr.position = pos;
            Prex = pos.x;
            Prez = pos.z;
        }
    }
}
