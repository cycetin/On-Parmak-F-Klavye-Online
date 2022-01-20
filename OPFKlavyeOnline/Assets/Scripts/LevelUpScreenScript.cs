using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;



public class LevelUpScreenScript : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI score;
    public TextMeshProUGUI next;
    public TextMeshProUGUI userName;
    public TextMeshProUGUI level;
    public TextMeshProUGUI time;
    public TextMeshProUGUI dateTime;
    public TextMeshProUGUI trueCount;
    public TextMeshProUGUI falseCount;
    public TextMeshProUGUI missedCount;
    public TextMeshProUGUI initScore;
    public TextMeshProUGUI average;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI levelText        ;
    public TextMeshProUGUI lettersText;
    public TMP_InputField lastScores;
    string letters = "";
    public Dropdown levelDrop;
    string path = "";
    string content = "";
    


    
    private void OnEnable()
    {

       

                    
        dateTime.text = System.DateTime.Now.ToString();
        nameText.text = userName.text;
        levelText.text = level.text;


        switch (int.Parse(levelText.text))
        {
            case 0:
                letters = levelDrop.options[levelDrop.value].text;
                break;
            case 1:
                letters = "AK";
                break;
            case 2:
                letters = "AKE";
                break;
            case 3:
                letters = "AKEM";
                break;
            case 4:
                letters = "AKEMİ";
                break;
            case 5:
                letters = "AKEMİL";
                break;
            case 6:
                letters = "AKEMİLU";
                break;
            case 7:
                letters = "AKEMİLUY";
                break;
            case 8:
                letters = "AKEMİLUYT";
                break;
            case 9:
                letters = "AKEMİLUYTÜ";
                break;
            case 10:
                letters = "AKEMİLUYTÜŞ";
                break;
            case 11:
                letters = "AKEMİLUYTÜŞI";
                break;
            case 12:
                letters = "AKEMİLUYTÜŞIR";
                break;
            case 13:
                letters = "AKEMİLUYTÜŞIRS";
                break;
            case 14:
                letters = "AKEMİLUYTÜŞIRSC";
                break;
            case 15:
                letters = "AKEMİLUYTÜŞIRSCZ";
                break;
            case 16:
                letters = "AKEMİLUYTÜŞIRSCZO";
                break;
            case 17:
                letters = "AKEMİLUYTÜŞIRSCZOD";
                break;
            case 18:
                letters = "AKEMİLUYTÜŞIRSCZODN";
                break;
            case 19:
                letters = "AKEMİLUYTÜŞIRSCZODNĞ";
                break;
            case 20:
                letters = "AKEMİLUYTÜŞIRSCZODNĞÇ";
                break;
            case 21:
                letters = "AKEMİLUYTÜŞIRSCZODNĞÇG";
                break;
            case 22:
                letters = "AKEMİLUYTÜŞIRSCZODNĞÇGH";
                break;
            case 23:
                letters = "AKEMİLUYTÜŞIRSCZODNĞÇGHV";
                break;
            case 24:
                letters = "AKEMİLUYTÜŞIRSCZODNĞÇGHVB";
                break;
            case 25:
                letters = "AKEMİLUYTÜŞIRSCZODNĞÇGHVBF";
                break;
            case 26:
                letters = "AKEMİLUYTÜŞIRSCZODNĞÇGHVBFP";
                break;
            case 27:
                letters = "AKEMİLUYTÜŞIRSCZODNĞÇGHVBFPJ";
                break;
            case 28:
                letters = "AKEMİLUYTÜŞIRSCZODNĞÇGHVBFPJÖ";
                break;
            case 29:
                letters = "AKEMİLUYTÜŞIRSCZODNĞÇGHVBFPJÖ.";
                break;
            case 30:
                letters = "AKEMİLUYTÜŞIRSCZODNĞÇGHVBFPJÖ,";
                break;
        }
        CreateText();
        CreateLastScores();
        ReadTextFile();
        lettersText.text = letters;
      
    }

    void Start()
    {

       

    }




    private void ReadTextFile()
    {
        Stack lines = new Stack();
        if (level.text.Equals("0"))
        {
            path = "OyuncuKayıtları/" + userName.text + "/" + userName.text + " Seviye " + letters + " Skorları.txt";
        }
        else
        {
            path = "OyuncuKayıtları/" + userName.text + "/" + userName.text + " Seviye " + level.text + " Skorları.txt";
        }
        StreamReader inp_stm = new StreamReader(path);

        while (!inp_stm.EndOfStream)
        {
            lines.Push(inp_stm.ReadLine());           
            
        }

        inp_stm.Close();
        string str = "";
        int counter = 0;
        while (lines.Count>2&&counter<25)
        {
            str = str + lines.Pop() + "\n";
            counter++;
        }

        lastScores.text = str;
    }

    private void CreateLastScores()
    {
        System.IO.Directory.CreateDirectory("OyuncuKayıtları/" + userName.text + "/");
        //Path of the file
        if (level.text.Equals("0"))
        {
             path = "OyuncuKayıtları/" + userName.text + "/" + userName.text + " Seviye " + letters + " Skorları.txt";
        }
        else
        {
             path = "OyuncuKayıtları/" + userName.text + "/" + userName.text + " Seviye " + level.text + " Skorları.txt";
        }
        
        //Create File if it doesn't exist
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "                              " + userName.text + " Seviye: " + level.text+" Harfler: "+letters+" Skorları \n\n");
        }
        //Content of the file
   
        //Add some to text to it

        String content = System.DateTime.Now.ToString().PadRight(17, ' ') + " | " + time.text.PadRight(5, ' ') + " | " + trueCount.text.PadRight(9-trueCount.text.Length, ' ') + " | " + falseCount.text.PadRight(9-falseCount.text.Length, ' ') + " | " + missedCount.text.PadRight(9-missedCount.text.Length, ' ') + " | " + initScore.text.PadRight(9-initScore.text.Length, ' ') + " | " + average.text.PadRight(10-average.text.Length, ' ')+"\n";
        File.AppendAllText(path, content);
    }




    // Update is called once per frame
    void Update()
    {
      
    }

    void CreateText()
    {
        System.IO.Directory.CreateDirectory("OyuncuKayıtları/"+userName.text+"/");
        //Path of the file
        string path ="OyuncuKayıtları/"+userName.text+"/"+userName.text+" Kayıtları.txt";
        //Create File if it doesn't exist
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "                              " + userName.text+ " Kayıtları \n\n");
        }
        //Content of the file
        content =

             "Tarih: " + System.DateTime.Now + "\n" +
             "Seviye: " + level.text + "\n" +
             "Harfler: " + letters + "\n" +
             "Süre: " + time.text + "\n" +
             "Doğru: " + trueCount.text + "\n" +
             "Yanlış: " + falseCount.text + "\n" +
             "Kaçan: " + missedCount.text + "\n" +
             "Skor: " + initScore.text + "\n" +
             "Ortalama: " + average.text + "\n" +
             "------------------------------------------------------------------------\n"
             ;



        //Add some to text to it
        File.AppendAllText(path, content);
    }

    

}
