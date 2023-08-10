using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour
{
    public Sprite playSprite;
    public Sprite pauseSprite;
    public AudioClip buttonClickSound; // Add this variable to hold the button click sound.

    private bool isPaused = false;
    private Image buttonImage;
    private AudioSource audioSource; // Add this variable to reference the AudioSource component.

    private void Awake()
    {
        buttonImage = GetComponent<Image>();
        audioSource = GetComponent<AudioSource>(); // Get the AudioSource component.
    }

    private void Start()
    {
        buttonImage.sprite = playSprite;
    }

    public void OnButtonClick()
    {
        if (isPaused)
        {
            ResumeGame();
        }
        else
        {
            PauseGame();
        }

        PlayButtonClickSound(); // Play the button click sound when the button is clicked.
    }

    private void PauseGame()
    {
        Time.timeScale = 0f;
        isPaused = true;
        buttonImage.sprite = pauseSprite;
    }

    private void ResumeGame()
    {
        Time.timeScale = 1f;
        isPaused = false;
        buttonImage.sprite = playSprite;
    }

    private void PlayButtonClickSound()
    {
        // Check if the audio clip is assigned and the audio source is not playing to avoid overlapping sounds.
        if (buttonClickSound != null && !audioSource.isPlaying)
        {
            audioSource.clip = buttonClickSound;
            audioSource.Play();
        }
    }
}
