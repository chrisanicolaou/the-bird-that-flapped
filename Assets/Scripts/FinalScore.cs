using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Text finalScore;
    void Start()
    {
        finalScore = GameObject.Find("FinalScore").GetComponent<Text>();
        finalScore.text = "Final Score: " + Globals.score.ToString();
    }
}
