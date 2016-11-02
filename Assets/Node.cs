using UnityEngine;

public class Node : MonoBehaviour {

	public Color hoverColor;
	public Vector3 positionOffset;

	private GameObject turret;

	private Renderer rend;
	private Color startColor;

	void Awake () {
		rend = GetComponent <Renderer> ();
		startColor = rend.material.color;
	}

	void OnMouseDown () {
		if (turret != null) {
			Debug.Log ("Can't Build There! - TODO: Display On Screen.");
			return;
		}

		GameObject turretToBuild = BuildManager.instance.GetTurretToBuild ();
		turret = Instantiate (turretToBuild, transform.position + positionOffset, transform.rotation) as GameObject;


	}

	void OnMouseEnter () {
		rend.material.color = hoverColor;
	}

	void OnMouseExit () {
		rend.material.color = startColor;
	}

}
