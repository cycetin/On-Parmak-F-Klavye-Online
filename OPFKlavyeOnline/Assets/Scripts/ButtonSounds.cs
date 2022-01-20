using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSounds : MonoBehaviour
{
    public AudioSource buttonFocusSound;
  

    public void focusSound()
    {
        buttonFocusSound.Play();

    }
  

}
