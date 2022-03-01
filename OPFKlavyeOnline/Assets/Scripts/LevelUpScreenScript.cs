using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using FirebaseWebGL.Examples.Utils;
using FirebaseWebGL.Scripts.FirebaseBridge;
using FirebaseWebGL.Scripts.Objects;


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
    public static int id = 0;

  

  
 

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

        lettersText.text = letters;            

        Infos log = new Infos();
        log.date = System.DateTime.Now.ToString("dd.MM.yyyy - HH:mm ");
        log.level = level.text;
        log.letters = letters;
        log.time = time.text;
        log.trueCount = trueCount.text;
        log.falseCount = falseCount.text;
        log.missedCount = missedCount.text;
        log.initScore = initScore.text;
        log.average = average.text;    


        string json1 = JsonUtility.ToJson(log);
        FirebaseDatabase.PushJSON(userName.text, json1, gameObject.name, "DisplayInfo", "DisplayErrorObject");  
       
        //   FirebaseDatabase.PostJSON(userName.text, json, gameObject.name, "DisplayInfo", "DisplayErrorObject");
        FirebaseDatabase.GetJSON(userName.text, gameObject.name, "DisplayData", "DisplayErrorObject");





    }


    void Start()
    {

    }
    public static string getBetween(string strSource, string strStart, string strEnd)
    {
        
            int Start, End;
            Start = strSource.IndexOf(strStart, 0) + strStart.Length;
            End = strSource.IndexOf(strEnd, Start);      
            return strSource.Substring(Start, End - Start);
      
    }

    public void DisplayData(string data)
    {          
        string[] infosArray = data.Split(new string[] { "}," }, StringSplitOptions.None);
       
        int stopPoint;
        if (infosArray.Length>19)
        {
            stopPoint = infosArray.Length - 20;
        }
        else
        {
            stopPoint = 0;
        }
        string lastScoreText = "";

        for (int i = infosArray.Length-1; i >= stopPoint; i--)
        {
           // Console.WriteLine(infosArray[i]);
            string avarage= getBetween(infosArray[i], "average", "date");
            string date = getBetween(infosArray[i], "date", "falseCount");
            string falseC = getBetween(infosArray[i], "falseCount", "initScore");
            string iScore = getBetween(infosArray[i], "initScore", "letters");
            string letters1 = getBetween(infosArray[i], "letters", "level");
            string level = getBetween(infosArray[i], "level", "missedCount");
            string missedC = getBetween(infosArray[i], "missedCount", "time");
            string time = getBetween(infosArray[i], "time", "trueCount");
            string trueC1 = infosArray[i].Split(',')[infosArray[i].Split(',').Length - 1].Split(':')[1];           
            string trueC = getBetween(trueC1, "+", "\"");   

            if (getBetween(level, "\":\"", "\",\"").Equals(levelText.text))
            {
                string str = getBetween(date, "\":\"", "\",\"").PadRight(17, ' ') + " | " + getBetween(time, "\":\"", "\",\"").PadRight(5, ' ') + " | " + trueC.PadRight(9 - trueC.Length, ' ') + " | " + getBetween(falseC, "\":\"", "\",\"").PadRight(9 - getBetween(falseC, "\":\"", "\",\"").Length, ' ') + " | " + getBetween(missedC, "\":\"", "\",\"").PadRight(9 - getBetween(missedC, "\":\"", "\",\"").Length, ' ') + " | " + getBetween(iScore, "\":\"", "\",\"").PadRight(9 - getBetween(iScore, "\":\"", "\",\"").Length, ' ') + " | " + getBetween(avarage, "\":\"", "\",\"").PadRight(10 - getBetween(avarage, "\":\"", "\",\"").Length, ' ') + "\n";

                lastScoreText = lastScoreText + str + "\n";
            }          
        }
       
        lastScores.text = lastScoreText; 
       
    }
    public void DisplayInfo(string info)
    {
       
        Debug.Log(info);
    }

    public void DisplayErrorObject(string error)
    {
        var parsedError = StringSerializationAPI.Deserialize(typeof(FirebaseError), error) as FirebaseError;
        DisplayError(parsedError.message);
    }
    public void DisplayError(string error)
    {
      
        Debug.LogError(error);
    }     
}
