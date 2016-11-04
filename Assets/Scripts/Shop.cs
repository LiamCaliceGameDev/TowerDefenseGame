using UnityEngine;

public class Shop : MonoBehaviour {

	BuildManager buildManager;

	void Start () {
		buildManager = BuildManager.instance;
	}

	public void PurchaseStandardTurret () {
		Debug.Log ("Standard Turret Selected!");
		buildManager.SetTurretToBuild (buildManager.standardTurretPrefab);
	}

	public void PurchaseMissileLuncher () {
		Debug.Log ("Missile Luncher Selected!");
		buildManager.SetTurretToBuild (buildManager.missileLuncherPrefab);
	}

}
