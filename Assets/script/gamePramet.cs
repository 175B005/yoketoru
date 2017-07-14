using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamePramet : MonoBehaviour {
	//自分のインスタンス
	private static gamePramet _instance;//インスタンス←スタティックから生成される
	//スコアテキスト　　　　　　　　　　　　
	public Text scoreText;
	//
	private static int _score;
	//_は商業用じゃないよーっていう表記？らしい

	void Awake(){//スクリプトのインスタンスが呼び出されたときに、実行。startよりも早い
		_instance = this;
	}
	public static void AddScore(int add){
		_score += add;
		if (_score > 999999) {
			_score = 999999;
		}
		DrawScore ();
	}

	public static void SetScore(int sc){
		_score = sc;
		DrawScore ();
	}
	public static void DrawScore(){//クラスの中で動く１
		//scoreText←では参照できない。
		_instance.scoreText.text = "Score" + _score.ToString("D6");
	}
}
		
