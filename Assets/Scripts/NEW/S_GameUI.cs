using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour {

	public GameObject gameUI;

	void Start () {
		FindObjectOfType<Player> ().OnDeath += OnGameOver;
	}

	void OnGameOver() {
		gameUI.SetActive (true);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

}