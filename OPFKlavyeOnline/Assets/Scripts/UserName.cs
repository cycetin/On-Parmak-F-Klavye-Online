using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Globalization;
public class UserName : MonoBehaviour
{
    public TMP_Dropdown usernameDrp;
    public static new string name="OYUNCU";
    public static  int userPoint = 0;
    public static int trueCount = 0;
    public static int falseCount = 0;
    public static int missCount = 0;
    public static int userLevel = 1;
    public AudioSource buttonFocusSound;
    public AudioSource buttonClickSound;
    public AudioSource KeyPressSound;


    public void keySound()
    {
        KeyPressSound.Play();
    }
    public void focusSound()
    {
        buttonFocusSound.Play();

    }
    public void clickSound()
    {
        buttonClickSound.Play();
    }
    public void Next()

    {
        if (usernameDrp.captionText.text.Length>0)
        {
            name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(usernameDrp.captionText.text);
        }
        

    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
