using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//シーン遷移に必要なライブラリを宣言
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

    //シーンを呼び出すためのメソッド
    public void LoadingNewScene(){
        //呼び出すシーン名を引数にシーンを読み込む
        SceneManager.LoadScene("Main");
    }
}
