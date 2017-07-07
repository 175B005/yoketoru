using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



/*
1.Oキーゲームオーバー
2.cキーでクリア

*/
public class GameManager : MonoBehaviour {

	public static string NextScene = "";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//oキー
		if (Input.GetKeyDown (KeyCode.O)) {
			NextScene = "gameover";
		}
		if (Input.GetKeyDown (KeyCode.C)) {
			NextScene = "game_comprete";
		}
		//シーン切り替え↓
		if (NextScene.Length > 0) {
			SceneManager.LoadSceneAsync (NextScene,LoadSceneMode.Additive);
			NextScene = "";
			enabled = false;
		}
	}

}