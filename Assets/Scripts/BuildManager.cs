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

	public GameObject buildEffect;


	private TurretBlueprint turretToBuild;
	private Node selectedNode;

	public NodeUI nodeUI;

	public bool CanBuild {get { return turretToBuild != null; } }
	public bool HasMoney {get { return PlayerStats.Money >= turretToBuild.cost; } }


	public void BuildTurretOn (Node node) {

		if (PlayerStats.Money < turretToBuild.cost) {
			Debug.Log ("Not Enough Money To Build That!");
			return;
		}

		PlayerStats.Money -= turretToBuild.cost;
		GameObject turret = Instantiate (turretToBuild.prefab, node.GetBuildPosition (), Quaternion.identity) as GameObject;
		node.turret = turret;

		GameObject effect = Instantiate (buildEffect, node.GetBuildPosition (), Quaternion.identity) as GameObject;
		Destroy (effect, 5f);

		Debug.Log ("Turret Built! Money Left: " + PlayerStats.Money); 

	}

	public void SelectNode (Node node) {
		if (selectedNode == node) {
			DeselectNode ();
			return;
		}
		selectedNode = node;
		turretToBuild = null;

		nodeUI.SetTarget (node);
	}

	public void DeselectNode () {
		selectedNode = null;
		nodeUI.Hide ();
	}

	public void SelectTurretToBuild (TurretBlueprint turret) {
		turretToBuild = turret;
		DeselectNode ();
	}


}
