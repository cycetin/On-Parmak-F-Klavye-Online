using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Runtime.InteropServices;
using System.Text;

public class MainMenu : MonoBehaviour
{

  
    // API DECLARATIONS
  //  private const uint KLF_ACTIVATE = 1; // activate the layout
  //  private const int KL_NAMELENGTH = 9; // length of the keyboard buffer
   


   /* [DllImport("user32.dll")]
    private static extern long LoadKeyboardLayout(
    string pwszKLID, // input locale identifier
    uint Flags // input locale identifier options
    );
    [DllImport("user32.dll")]
    private static extern long GetKeyboardLayoutName(
    System.Text.StringBuilder pwszKLID
    );*/
    public AudioSource buttonFocusSound;
    public AudioSource buttonClickSound;
    public GameObject keyboardSettingsScreen;
    public void focusSound()
    {
        buttonFocusSound.Play();

    }

    private void Start()
    {
       /* if (!KeyboardLayout.isFirst)
        {
            CheckAndQuit();
        }*/
    }


    public void CheckAndQuit()
    {
       /* if (KeyboardLayout.isChange)
        {
            keyboardSettingsScreen.gameObject.SetActive(true);
        }
        else
        {
            Application.Quit();
        }*/
    }
 
    public void QuitGameDefault()
    {
      /*  LoadKeyboardLayout(KeyboardLayout.keyboardType, KLF_ACTIVATE);
        Application.Quit();*/
    }
    public void QuitGameTurkishF()
    {
       /* LoadKeyboardLayout("0001041F", KLF_ACTIVATE);
        Application.Quit();*/
    }
}
