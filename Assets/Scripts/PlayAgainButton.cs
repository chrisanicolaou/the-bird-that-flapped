using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgainButton : MonoBehaviour
{
    public void OnButtonPress() 
    {
        Globals.score = 0;
        SceneManager.LoadScene("SampleScene");
    }
}
