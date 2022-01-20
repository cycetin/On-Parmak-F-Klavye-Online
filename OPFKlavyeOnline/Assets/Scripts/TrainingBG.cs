using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TrainingBG : MonoBehaviour
{
    private string imageName;
    public TextMeshProUGUI levelUI;
    static public int levelName;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        levelName = int.Parse(levelUI.text);
        if (levelUI.text == "1" || levelUI.text == "2" || levelUI.text == "3")
        {
            imageName = "t1";
        }
        else if (levelUI.text == "4" || levelUI.text == "5" || levelUI.text == "6")
        {
            imageName = "t2";
        }
        else if (levelUI.text == "7" || levelUI.text == "8" || levelUI.text == "9")
        {
            imageName = "t3";
        }
        else if (levelUI.text == "10" || levelUI.text == "11" || levelUI.text == "12")
        {
            imageName = "t4";
        }
        else if (levelUI.text == "13" || levelUI.text == "14" || levelUI.text == "15")
        {
            imageName = "t5";
        }
        else if (levelUI.text == "16" || levelUI.text == "17" || levelUI.text == "18")
        {
            imageName = "t6";
        }
        else if (levelUI.text == "19" || levelUI.text == "20" || levelUI.text == "21")
        {
            imageName = "t7";
        }
        else if (levelUI.text == "22" || levelUI.text == "23" || levelUI.text == "24")
        {
            imageName = "t8";
        }
        else if (levelUI.text == "25" || levelUI.text == "26" || levelUI.text == "27")
        {
            imageName = "t9";
        }
        else if (levelUI.text == "28" || levelUI.text == "29" || levelUI.text == "30")
        {
            imageName = "t10";
        }
        else
        {
            imageName = "t0";
        }

        this.gameObject.GetComponent<Image>().sprite = Resources.Load(imageName, typeof(Sprite)) as Sprite;
    }
}
