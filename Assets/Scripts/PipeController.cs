using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PipeController : MonoBehaviour
{
    public float speed = 4;
    public GameObject pipe;
    // Update is called once per frame

    public Text currentScore;

    public AudioSource soundfx;

    void Start() {
        currentScore = GameObject.Find("Score").GetComponent<Text>();
        soundfx = soundfx.GetComponent<AudioSource>();
    }
    void Update()
    {
        pipe.transform.position += Vector3.left * speed * Time.deltaTime;
    }
    
    private void OnCollisionEnter2D(Collision2D col)
    {
        SceneManager.LoadScene("GameOver");
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        soundfx.Play(0);
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        Globals.score ++;
        currentScore.text = Globals.score.ToString();
    }

}
