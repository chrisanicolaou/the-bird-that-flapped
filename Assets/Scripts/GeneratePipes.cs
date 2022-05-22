using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePipes : MonoBehaviour
{
    public GameObject Pipes;
    private float Timer = 2f;

    GameObject NewPipes;

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0f)
        {
            NewPipes = Instantiate(Pipes,(new Vector3 (10, Random.Range(-4, 5))), transform.rotation) as GameObject;
            Timer = 2f;
        }
    }
}
