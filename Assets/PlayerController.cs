using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    //移動速度を設定する変数
    public float speed = 8f;
    //移動範囲を設定する変数
    public float moveableRange = 5.5f;

    //砲弾の威力を設定する変数
    public float power = 1000f;
    //砲弾のオブジェクトを設定する変数(ここに作成したプレハブをアタッチする)
    public GameObject cannnonBall;
    //砲弾の発射口を設定するための変数
    public Transform spawnPoint;

	// Use this for initialization
	void Start () {
		
	}
	
    //Update関数　ゲーム中に繰り返し実行される関数
	// Update is called once per frame
	void Update () {
        //キー入力を受け取ってプレイヤーを動かす処理
        //transform.Translate オブジェクトを移動させる命令
        //Input.GetAxisRaw キー入力に合わせた値を取得する命令
        //Horizontal 左右のキーもしくはAとD
        //Time.DeltaTime 端末スペックに関係なく１秒間で進む距離を調整　実行する端末差が出ないようにする
        transform.Translate(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, 0, 0);
        //プレイヤーの移動範囲を制限する処理
        //Mathf.Clamp(transform.position.x, -moveableRange, moveableRange), transform.position.y) 
        //X軸のポジションには制限をかける（-5.5~5.5まで移動可能）Y軸は制限をかけずそのままにする
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -moveableRange, moveableRange), transform.position.y);
	    
        //スペースキーの入力で実行
        if(Input.GetKeyDown(KeyCode.Space)){
            Shoot();
        }
    }

    void Shoot(){
        //cannnonBallに設定したプレハブからインスタンスを生成
        //spawnPoint変数に設定されたオブジェクトの位置情報が指定
        //Quaternion.identityで角度を0,0,0にする
        GameObject newBullet = Instantiate(cannnonBall, spawnPoint.position, Quaternion.identity) as GameObject;
        //AddForceでオブジェクトに対して物理的な力を加える（インスタンスのRigidbody2Dコンポーネントに対し物理的な力を加えてインスタンスを移動）
        //Vector3.up 上向きを指定　powerで砲弾の威力を指定している
        newBullet.GetComponent<Rigidbody2D>().AddForce(Vector3.up * power);

    }
}
