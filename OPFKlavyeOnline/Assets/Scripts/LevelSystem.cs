using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSystem : MonoBehaviour
{

    public AudioSource buttonFocusSound;
    public AudioSource buttonClickSound;

    public void focusSound()
    {
        buttonFocusSound.Play();

    }
    public void clickSound()
    {
        buttonClickSound.Play();
    }
 
}
