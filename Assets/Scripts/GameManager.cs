using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	private bool gameEnded = false; 

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
		Debug.Log ("GAME OVER!");
	}

}
