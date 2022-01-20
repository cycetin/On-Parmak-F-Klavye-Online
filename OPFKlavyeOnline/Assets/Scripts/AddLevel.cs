using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class AddLevel : MonoBehaviour
{
    public Text if1Text;

    string file = "Levels.txt";

    public void AddLevelTxt()
    {
        string inputValue = if1Text.text.ToUpper().Replace(" ", "");
        if (File.Exists(file))
        {
            File.AppendAllText(file, inputValue + "\n");
        }


    }

}
