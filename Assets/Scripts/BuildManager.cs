using UnityEngine;

public class BuildManager : MonoBehaviour {

	public static BuildManager instance;

	void Awake () {
		if (instance != null) {
			Debug.LogError ("More Than One BuildManager In Scene!");
			return;
		}
		instance = this;
	}

	public GameObject standardTurretPrefab;
	public GameObject missileLuncherPrefab;


	private TurretBlueprint turretToBuild;

	public bool CanBuild {get { return turretToBuild != null; } }

	public void BuildTurretOn (Node node) {

		if (PlayerStats.Money < turretToBuild.cost) {
			Debug.Log ("Not Enough Money To Build That!");
			return;
		}

		PlayerStats.Money -= turretToBuild.cost;
		GameObject turret = Instantiate (turretToBuild.prefab, node.GetBuildPosition (), Quaternion.identity) as GameObject;
		node.turret = turret;

		Debug.Log ("Turret Built! Money Left: " + PlayerStats.Money); 

	}

	public void SelectTurretToBuild (TurretBlueprint turret) {
		turretToBuild = turret;
	}


}
