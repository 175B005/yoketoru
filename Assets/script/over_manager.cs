using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class over_manager : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		//Fire1キーが押されたらGameシーンに切り替え
		if (Input.GetButtonDown ("Fire1")) {
			SceneManager.LoadSceneAsync ("title1");

		}
	}
}