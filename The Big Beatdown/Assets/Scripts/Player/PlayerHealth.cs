using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
	// Private variables
	private AudioSource playerAudio;
	private bool isDead;
	private bool damaged;

	// Public variables
	public int currentHealth;
	public int totalHealth = 100;                                                            
	public Slider healthSlider;                                 
	public Image damageImage;
	public AudioClip hitClip;
	public AudioClip deathClip;
	public float flashSpeed = 5f;                               
	public Color flashColour = new Color(1f, 0f, 0f, 0.1f);

	// Ran once
	void Awake()
	{
		healthSlider.value = totalHealth; // Set slider value to totalhealth
		healthSlider.value = currentHealth; // Set slider value to current health. 25 at level one

		playerAudio = GetComponent<AudioSource>(); // Get audio soruce component
	}

	// Ran each frame
	void Update()
	{
		if (damaged) // If damaged is ture
		{
			playerAudio.clip = hitClip; // Set clip to hitClip

			playerAudio.Play(); // Play clip

			damageImage.color = flashColour; // Flash screen red	
		}
		else
		{
			damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime); // Remove color over time
		}
		damaged = false; // Set damage to false
	}

	// Function used by other function to play audio
	public void ClipPlay(AudioClip clip)
	{
		playerAudio.clip = clip; // Set clip to clip of function

		playerAudio.volume = 100; // Set volume to 100

		playerAudio.Play(); // Play clip
	}

	// Function used to remove health from player
	public void TakeDamage(int amount)
	{
		damaged = true; // Set damage to true

		currentHealth -= amount; // Remove damge from health

		healthSlider.value = currentHealth; // Adjust slider value

		playerAudio.clip = hitClip;

		playerAudio.Play(); // Play clip

		if (currentHealth <= 0 && !isDead) // If player health is zero or below
		{
			Death(); // Run dealth function
		}
	}

	// Increase health function used by pizza to increase health of player
	public void IncreaseHealth(int amount)
	{
		currentHealth += amount; // Current health increases by amount

		healthSlider.value = currentHealth; // Adjust slider value

		if (currentHealth >= totalHealth) // If currentHealth is above totalHealth 
		{
			currentHealth = totalHealth; // Set currentHealth to totalHealth
		}
	}

	// Death function for player
	void Death()
	{
		isDead = true; // Set dead to true

		playerAudio.clip = deathClip; // Set clip to death clip

		playerAudio.volume = 100; // Set volume to 100

		playerAudio.Play(); // Play clip

		SceneManager.LoadScene("Dead"); // Change scene to Dead
	}
}