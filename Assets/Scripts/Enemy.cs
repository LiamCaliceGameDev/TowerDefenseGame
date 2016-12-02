using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {

	public float startSpeed = 10f;
	[HideInInspector]
	public float speed;

	public float startHealth = 100;
	private float health;

	public int reward = 50;

	public GameObject deathEffect;

	[Header("Unity Stuff")]
	public Image healthBar;

	void Start () {
		speed = startSpeed;
		health = startHealth;
	}

	public void TakeDamage (float amount) {
		health -= amount;
		healthBar.fillAmount = health / startHealth;
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
