using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
	public int currentHealth;
	public int totalHealth = 100;                                                            
	public Slider healthSlider;                                 
	public Image damageImage;
	public AudioClip deathClip;                                 
	public float flashSpeed = 5f;                               
	public Color flashColour = new Color(1f, 0f, 0f, 0.1f);

	private AudioSource playerAudio;
	private bool isDead;
	private bool damaged;

	void Awake()
	{
		healthSlider.value = totalHealth;
		currentHealth = 25;
		healthSlider.value = currentHealth;

		playerAudio = GetComponent<AudioSource>();
	}

	void Update()
	{
		if (damaged)
		{
			playerAudio.clip = deathClip;

			damageImage.color = flashColour;

			playerAudio.Play();
		}
		else
		{
			damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
		}
		damaged = false;
	}

	public void ClipPlay(AudioClip clip)
	{
		playerAudio.clip = clip;

		playerAudio.volume = 100;

		playerAudio.Play();
	}

	public void TakeDamage(int amount)
	{
		damaged = true;

		currentHealth -= amount;

		healthSlider.value = currentHealth;

		if (currentHealth <= 0 && !isDead)
		{
			Death();
		}
	}

	public void IncreaseHealth(int amount)
	{
		currentHealth += amount;

		healthSlider.value = currentHealth;

		if (currentHealth >= totalHealth)
		{
			currentHealth = totalHealth;
		}
	}

	void Death()
	{
		isDead = true;

		SceneManager.LoadScene("Dead");
	}
}