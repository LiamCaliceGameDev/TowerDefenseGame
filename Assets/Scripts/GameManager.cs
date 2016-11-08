using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static bool gameEnded;

	public GameObject gameOverUI;


	void Start () {
		gameEnded = false;
	}

	void Update () {
		if (gameEnded) {
			return;
		}

		if (PlayerStats.Lives <= 0f) {
			EndGame ();
		}
	}

	void EndGame () {
		gameEnded = true;
		gameOverUI.SetActive (true);
	}

}
