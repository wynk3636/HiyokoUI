using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObj : MonoBehaviour {

    //消去するまでの時間を指定する変数
    public float deleteTime = 2.0f;

	// Use this for initialization
	void Start () {
        //Destroy関数　オブジェクトの削除
        Destroy(gameObject, deleteTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
