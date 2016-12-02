using UnityEngine;

public class Enemy : MonoBehaviour {

	public float startSpeed = 10f;
	[HideInInspector]
	public float speed;

	public float health = 100;

	public int reward = 50;

	public GameObject deathEffect;

	void Start () {
		speed = startSpeed;
	}

	public void TakeDamage (float amount) {
		health -= amount;
		if (health <= 0f) {
			Die ();
		}
	}

	public void Slow (float pct) {
		speed = startSpeed * (1 - pct);
	}

	void Die () {
		PlayerStats.Money += reward;

		GameObject effect = Instantiate (deathEffect, transform.position, Quaternion.identity) as GameObject;
		Destroy (effect, 5f);

		Destroy (gameObject);
	}

} 
