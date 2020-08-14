using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity : MonoBehaviour
{
    public GameObject planet;       // 引力の発生する星
    public float accelerationScale; // 加速度の大きさ
    private Rigidbody rb;//リジットボディ
    string target;//オブジェクトの名前用
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        target = planet.name;
    }

    //引力計算＆適応
    void FixedUpdate()
    {
        var point = GameObject.Find(target);
        if(point != null){
            var direction = point.transform.position - transform.position;
            direction.Normalize();

            var directionX = point.transform.position.x - this.transform.position.x;
            var directionZ = point.transform.position.z - this.transform.position.z;
            var distance = Mathf.Sqrt(directionX * directionX + directionZ * directionZ);
            distance *= distance;
            //Debug.Log(distance);
            if (2 > distance && distance > 0.5)
            {
                rb.AddForce(accelerationScale * direction, ForceMode.Acceleration);
            }
        }
    }
}
