using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartGame : MonoBehaviour
{
    public TextMeshProUGUI instructionText;
    public AudioSource backgroundMusic;
    private bool isPlaying;
    void Start()
    {
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isPlaying && Input.GetKeyDown(KeyCode.Space)) {
            isPlaying = true;
            instructionText.enabled = false;
            backgroundMusic.Play();
            Time.timeScale = 1f;
        }
    }
}
