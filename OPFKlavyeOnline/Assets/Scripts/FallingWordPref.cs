using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FallingWordPref : MonoBehaviour
{

    public float fallSpeed;
    bool isStart = false;
    private static int newRandom;
    public static int previous; 



    public void startFalling(float wpm)
    {
        fallSpeed = (wpm / 10000.0f) + 0.015f;
        isStart = true;

    }
    private void Start()
    {       
        previous = newRandom;
        while (Mathf.Abs(previous - newRandom) <= 2)
        {
            newRandom = Random.Range(-6, 7);
        }
        transform.position = new Vector3(newRandom, 5, 0);

    }

    void FixedUpdate()
    {
        if (isStart)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - fallSpeed, transform.position.z);
        }

    }
}
