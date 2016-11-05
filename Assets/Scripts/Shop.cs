using UnityEngine;

public class Shop : MonoBehaviour {


	public TurretBlueprint standardTurret;
	public TurretBlueprint missileLuncher;


	BuildManager buildManager;

	void Start () {
		buildManager = BuildManager.instance;
	}

	public void SelectStandardTurret () {
		Debug.Log ("Standard Turret Selected!");
		buildManager.SelectTurretToBuild (standardTurret);
	}

	public void SelectMissileLuncher () {
		Debug.Log ("Missile Luncher Selected!");
		buildManager.SelectTurretToBuild (missileLuncher);
	}

}
