using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FallingObjectImage : MonoBehaviour
{
    private string imageName;
    private string levelName;
    private Color[] myColors;

    void Start()
    {
        RectTransform rt = (RectTransform)this.transform;
        levelName = TrainingBG.levelName.ToString();
        if (levelName == "1" || levelName == "2" || levelName == "3")
        {
            imageName = "s1";
            rt.sizeDelta = new Vector2(40f, 40f);
            myColors = new Color[] {
        new Color(236/255f,113/255f,167/255f),
        new Color(73 / 255f, 182 / 255f, 185 / 255f),
        new Color(0 / 255f, 172 / 255f, 236 / 255f),
        new Color(251 / 255f, 200 / 255f, 117 / 255f),
        new Color(26 / 255f, 119 / 255f, 189 / 255f)};
        }
        else if (levelName == "4" || levelName == "5" || levelName == "6")
        {
            imageName = "s2";
            rt.sizeDelta = new Vector2(35f, 35f);
            myColors = new Color[] {
        new Color(244/255f,67/255f,54/255f),
        new Color(233 / 255f, 30 / 255f, 99 / 255f),
        new Color(156 / 255f, 39 / 255f, 176 / 255f),
        new Color(33 / 255f, 150 / 255f, 243 / 255f),//rgb(33,150,243)
        new Color(255 / 255f, 152 / 255f, 0 / 255f)};//rgb(255,152,0)
        }
        else if (levelName == "7" || levelName == "8" || levelName == "9")
        {
            imageName = "s3";
            rt.sizeDelta = new Vector2(30f, 30f);
            myColors = new Color[] {
        new Color(19/255f,111/255f,24/255f),
        new Color(191 / 255f, 26 / 255f, 4 / 255f),
        new Color(225 / 255f, 139 / 255f, 0 / 255f),
        new Color(230 / 255f, 96 / 255f, 43 / 255f),//rgb(33,150,243)
        new Color(109 / 255f, 186 / 255f, 44 / 255f)};//rgb(255,152,0)
        }
        else if (levelName == "10" || levelName == "11" || levelName == "12")
        {
            imageName = "s4";
            rt.sizeDelta = new Vector2(33f, 33f);
            myColors = new Color[] {
        new Color(19/255f,111/255f,24/255f),
        new Color(191 / 255f, 26 / 255f, 4 / 255f),
        new Color(225 / 255f, 139 / 255f, 0 / 255f),
        new Color(230 / 255f, 96 / 255f, 43 / 255f),//rgb(33,150,243)
        new Color(109 / 255f, 186 / 255f, 44 / 255f)};//rgb(255,152,0)
        }
        else if (levelName == "13" || levelName == "14" || levelName == "15")
        {
            imageName = "s5";
            rt.sizeDelta = new Vector2(30f, 30f);
            myColors = new Color[] {
        new Color(19/255f,111/255f,24/255f),
        new Color(191 / 255f, 26 / 255f, 4 / 255f),
        new Color(225 / 255f, 139 / 255f, 0 / 255f),
        new Color(230 / 255f, 96 / 255f, 43 / 255f),//rgb(33,150,243)
        new Color(109 / 255f, 186 / 255f, 44 / 255f)};//rgb(255,152,0)
        }
        else if (levelName == "16" || levelName == "17" || levelName == "18")
        {
            imageName = "s6";
            rt.sizeDelta = new Vector2(25f, 25f);
            myColors = new Color[] {
        new Color(255/255f,152/255f,0/255f),//rgb(255,152,0)
        new Color(233 / 255f, 30 / 255f, 99 / 255f),//rgb(233,30,99)
        new Color(0 / 255f, 188 / 255f, 212 / 255f),//rgb(0,188,212)
        new Color(139 / 255f, 195 / 255f, 74 / 255f), //rgb(139,195,74)       
        new Color(126 / 255f, 87 / 255f, 194 / 255f)};//rgb(126,87,194)
        }
        else if (levelName == "19" || levelName == "20" || levelName == "21")
        {
            imageName = "s7";
            rt.sizeDelta = new Vector2(25f, 25f);
            myColors = new Color[] {
        new Color(255/255f,152/255f,0/255f),//rgb(255,152,0)
        new Color(233 / 255f, 30 / 255f, 99 / 255f),//rgb(233,30,99)
        new Color(0 / 255f, 188 / 255f, 212 / 255f),//rgb(0,188,212)
        new Color(139 / 255f, 195 / 255f, 74 / 255f), //rgb(139,195,74)       
        new Color(126 / 255f, 87 / 255f, 194 / 255f)};//rgb(126,87,194)
        }
        else if (levelName == "22" || levelName == "23" || levelName == "24")
        {
            imageName = "s8";
            rt.sizeDelta = new Vector2(25f, 30f);
            myColors = new Color[] {
        new Color(255/255f,152/255f,0/255f),//rgb(255,152,0)
        new Color(233 / 255f, 30 / 255f, 99 / 255f),//rgb(233,30,99)
        new Color(0 / 255f, 188 / 255f, 212 / 255f),//rgb(0,188,212)
        new Color(139 / 255f, 195 / 255f, 74 / 255f), //rgb(139,195,74)       
        new Color(126 / 255f, 87 / 255f, 194 / 255f)};//rgb(126,87,194)
        }
        else if (levelName == "25" || levelName == "26" || levelName == "27")
        {
            imageName = "s0";
            rt.sizeDelta = new Vector2(30f, 30f);
            myColors = new Color[] {
        new Color(255/255f,152/255f,0/255f),//rgb(255,152,0)
        new Color(233 / 255f, 30 / 255f, 99 / 255f),//rgb(233,30,99)
        new Color(0 / 255f, 188 / 255f, 212 / 255f),//rgb(0,188,212)
        new Color(139 / 255f, 195 / 255f, 74 / 255f), //rgb(139,195,74)       
        new Color(126 / 255f, 87 / 255f, 194 / 255f)};//rgb(126,87,194)
        }
        else if (levelName == "28" || levelName == "29" || levelName == "30")
        {
            imageName = "s10";
            rt.sizeDelta = new Vector2(25f, 25f);
            myColors = new Color[] {
        new Color(255/255f,152/255f,0/255f),//rgb(255,152,0)
        new Color(233 / 255f, 30 / 255f, 99 / 255f),//rgb(233,30,99)
        new Color(0 / 255f, 188 / 255f, 212 / 255f),//rgb(0,188,212)
        new Color(139 / 255f, 195 / 255f, 74 / 255f), //rgb(139,195,74)       
        new Color(126 / 255f, 87 / 255f, 194 / 255f)};//rgb(126,87,194)
        }
        else
        {
            imageName = "s0";
            rt.sizeDelta = new Vector2(30f, 30f);
            myColors = new Color[] {                
        new Color(255/255f,152/255f,0/255f),//rgb(255,152,0)
        new Color(233 / 255f, 30 / 255f, 99 / 255f),//rgb(233,30,99)
        new Color(0 / 255f, 188 / 255f, 212 / 255f),//rgb(0,188,212)
        new Color(139 / 255f, 195 / 255f, 74 / 255f), //rgb(139,195,74)       
        new Color(126 / 255f, 87 / 255f, 194 / 255f)};//rgb(126,87,194)
        }
       


        this.GetComponent<Image>().overrideSprite = Resources.Load<Sprite>(imageName);
        this.GetComponent<Image>().color = myColors[Random.Range(0,5)];

    }


    void Update()
    {

    }
}
