using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackgroundImage : MonoBehaviour
{
    // Start is called before the first frame update
    private string imageName; 
    void Start()
    {
        if (SceneManager.GetActiveScene().name=="Level1" || SceneManager.GetActiveScene().name == "Level2" || SceneManager.GetActiveScene().name == "Level3" )
        {
            imageName = "1";
        }
        else if (SceneManager.GetActiveScene().name == "Level4" || SceneManager.GetActiveScene().name == "Level5" || SceneManager.GetActiveScene().name == "Level6")
        {
            imageName = "2";
        }
        else if (SceneManager.GetActiveScene().name == "Level7" || SceneManager.GetActiveScene().name == "Level8" || SceneManager.GetActiveScene().name == "Level9")
        {
            imageName = "3";
        }
        else if (SceneManager.GetActiveScene().name == "Level10" || SceneManager.GetActiveScene().name == "Level11" || SceneManager.GetActiveScene().name == "Level12")
        {
            imageName = "4";
        }
        else if (SceneManager.GetActiveScene().name == "Level13" || SceneManager.GetActiveScene().name == "Level14" || SceneManager.GetActiveScene().name == "Level15")
        {
            imageName = "5";
        }
        else if (SceneManager.GetActiveScene().name == "Level16" || SceneManager.GetActiveScene().name == "Level17" || SceneManager.GetActiveScene().name == "Level18")
        {
            imageName = "6";
        }
        else if (SceneManager.GetActiveScene().name == "Level19" || SceneManager.GetActiveScene().name == "Level20" || SceneManager.GetActiveScene().name == "Level21")
        {
            imageName = "7";
        }
        else if (SceneManager.GetActiveScene().name == "Level22" || SceneManager.GetActiveScene().name == "Level23" || SceneManager.GetActiveScene().name == "Level24")
        {
            imageName = "8";
        }
        else if (SceneManager.GetActiveScene().name == "Level25" || SceneManager.GetActiveScene().name == "Level26" || SceneManager.GetActiveScene().name == "Level27")
        {
            imageName = "9";
        }
        else if (SceneManager.GetActiveScene().name == "Level28" || SceneManager.GetActiveScene().name == "Level29" || SceneManager.GetActiveScene().name == "Level30")
        {
            imageName = "10";
        }
        this.gameObject.GetComponent<Image>().sprite = Resources.Load(imageName, typeof(Sprite)) as Sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
