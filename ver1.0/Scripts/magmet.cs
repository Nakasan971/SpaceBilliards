using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//使用しなかったScript



public class magmet : MonoBehaviour {
    public GameObject[] planet;       // 引力の発生する星
    public float coefficient;
    private Rigidbody rb;
    void Start () {
            rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate() {
        for (int i=0;i < planet.Length;i++) {
            var directionX = planet[i].GetComponent<Rigidbody>().transform.position.x - this.transform.position.x;
            var directionZ = planet[i].GetComponent<Rigidbody>().transform.position.z - this.transform.position.z;
            var distance = Mathf.Sqrt(directionX*directionX+directionZ*directionZ);
            distance *= distance;
            var gravity = coefficient * planet[i].GetComponent<Rigidbody>().mass * rb.mass / distance;
            if (distance<0.1) {
                rb.AddForce(gravity * directionX, transform.position.y, gravity * directionZ, ForceMode.Force);
            }
        }
    }
}
