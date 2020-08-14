using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMove : MonoBehaviour {

	void Start () {
	}
	
	//ゴリ押しで背景を動かす
	void FixedUpdate () {
      this.transform.Rotate(0, -0.02f, 0);       
	}
}
