using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiyokoGenerator : MonoBehaviour {

    //ひよこ玉のプレハブを設定する変数
    public GameObject obj;
    //生成間隔を設定する変数
    public float interval = 3.0f;

	// Use this for initialization
	void Start () {
        //InvokeRepeating 一定間隔で関数を呼び出すことができる
        //実行して0.1秒後に１回目　以後はintervalに設定されている間隔で
        InvokeRepeating("SpawnObj", 0.1f, interval);
	}
	
	// ひよこ玉生成の関数
    //objに設定されているプレハブのインスタンスを生成する
	void SpawnObj () {
        Instantiate(obj, transform.position, transform.rotation);
	}
}
