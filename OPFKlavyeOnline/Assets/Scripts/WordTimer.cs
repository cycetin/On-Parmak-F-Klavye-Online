using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WordTimer : MonoBehaviour
{

    public WordManager wordManager;
    public static float wordPerMinute;
    float next_spawn_time;
    public bool isStart = false;
    public Button setButton;
    private float startTime;
    private float elapsedTime;
    public InputField wpmInput;
    public GameObject levelUpScreen;




    public void levelUP()
    {
        wordPerMinute += 8;
    }
    public void startGame(float wpm)
    {
        next_spawn_time = wpm;

        if (wpmInput.text == "" || float.Parse(wpmInput.text) > 300.0f || float.Parse(wpmInput.text) < 60.0f)
        {
            wordPerMinute = 60.0f;
        }
        else
        {
            wordPerMinute = float.Parse(wpmInput.text);
        }



        isStart = true;
        startTime = Time.time;

    }
    private void Start()
    {

        //next_spawn_time = 60.0f / wordPerMinute;
    }
    void Update()
    {
        if (!levelUpScreen.gameObject.activeSelf)
        {
            if (isStart)
            {
                elapsedTime = Time.time - startTime;

                if (elapsedTime > next_spawn_time)
                {
                    //do stuff here (like instantiate)

                    wordManager.AddWord();


                    //increment next_spawn_time
                    next_spawn_time += 60.0f / wordPerMinute;
                }
            }
        }
        else
        {
            
            startTime = Time.time;
            next_spawn_time = 0;
        }


    }

}
