using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeQuality : MonoBehaviour
{
   void SetQuality(string name)
    {
        switch (name)
        {
            case "VeryLow":
                QualitySettings.SetQualityLevel(0);           
                break;
            case "Low":
                QualitySettings.SetQualityLevel(1);
                break;
            case "Medium":
                QualitySettings.SetQualityLevel(2);
                break;
            case "High":
                QualitySettings.SetQualityLevel(3);
                break;
            case "VeryHigh":
                QualitySettings.SetQualityLevel(4);
                break;

        }
    }

    public void ChangeQualities(string name)
    {
        SetQuality(name);
    }
}
