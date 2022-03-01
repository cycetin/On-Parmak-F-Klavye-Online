using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using FirebaseWebGL.Examples.Utils;
using FirebaseWebGL.Scripts.FirebaseBridge;
using FirebaseWebGL.Scripts.Objects;
using System;


public class HighscoreTable : MonoBehaviour
{

    public static Transform entryContainer;
    public static Transform entryTemplate;
    public static  List<Transform> highscoreEntryTransformList;
   
 


    public void DisplayData(string data)
    {

           int count = 0;
        entryContainer = transform.Find("highscoreEntryContainer");
        entryTemplate = entryContainer.Find("highscoreEntryTemplate");
        entryTemplate.gameObject.SetActive(false);

        Highscores highscores = new Highscores();
        List<HighscoreEntry> highscoreEntryList1 = new List<HighscoreEntry>();

        string[] infosArray = data.Split(new string[] { "}," }, StringSplitOptions.None);



        for (int i = infosArray.Length - 1; i >= 0; i--)
        {
            // Console.WriteLine(infosArray[i]);
              string str = getBetween(infosArray[i], "name", "score");
            //  Console.WriteLine(str+"\n");
              string uName = getBetween(str, "\":\"", "\",\"");
            Console.WriteLine(infosArray[i] + "---\n");
            string uScore = infosArray[i].Split(',')[infosArray[i].Split(',').Length - 1].Split(':')[1];
            if (i==infosArray.Length-1)
            {
               uScore= uScore.Substring(0, uScore.Length - 2);
            }
            
            
            

            
            HighscoreEntry h1 = new HighscoreEntry();
            h1.name = uName;
            h1.score = int.Parse(uScore);
            highscoreEntryList1.Add(h1);
            // Console.WriteLine(uName + "-" + uScore + " \n");
            // string trueC = getBetween(trueC1, "+", "\"");

            /*  if (getBetween(level, "\":\"", "\",\"").Equals(levelText.text))
              {
                  string str = getBetween(date, "\":\"", "\",\"").PadRight(17, ' ') + " | " + getBetween(time, "\":\"", "\",\"").PadRight(5, ' ') + " | " + trueC.PadRight(9 - trueC.Length, ' ') + " | " + getBetween(falseC, "\":\"", "\",\"").PadRight(9 - getBetween(falseC, "\":\"", "\",\"").Length, ' ') + " | " + getBetween(missedC, "\":\"", "\",\"").PadRight(9 - getBetween(missedC, "\":\"", "\",\"").Length, ' ') + " | " + getBetween(iScore, "\":\"", "\",\"").PadRight(9 - getBetween(iScore, "\":\"", "\",\"").Length, ' ') + " | " + getBetween(avarage, "\":\"", "\",\"").PadRight(10 - getBetween(avarage, "\":\"", "\",\"").Length, ' ') + "\n";

                  lastScoreText = lastScoreText + str + "\n";
              }*/
        }
        highscores.highscoreEntryList = highscoreEntryList1;
        for (int i = 0; i < highscores.highscoreEntryList.Count; i++)
        {
            
            for (int j = i + 1; j < highscores.highscoreEntryList.Count; j++)
            {
                if (highscores.highscoreEntryList[j].score > highscores.highscoreEntryList[i].score)
                {
                    // Swap
                    HighscoreEntry tmp = highscores.highscoreEntryList[i];
                    highscores.highscoreEntryList[i] = highscores.highscoreEntryList[j];
                    highscores.highscoreEntryList[j] = tmp;
                }
            }
        }

        highscoreEntryTransformList = new List<Transform>();

        foreach (HighscoreEntry highscoreEntry in highscores.highscoreEntryList)
        {
            if (count < 10)
            {
                CreateHighscoreEntryTransform(highscoreEntry, entryContainer, highscoreEntryTransformList);
            }
            count++;
        }


        Console.WriteLine(data);
       // getData = data;
       // Debug.Log(data);
    }

    public void DisplayInfo(string info)
    {
        Console.WriteLine(info);
       // Debug.Log(info);
    }

    public void DisplayErrorObject(string error)
    {
        var parsedError = StringSerializationAPI.Deserialize(typeof(FirebaseError), error) as FirebaseError;
        DisplayError(parsedError.message);
    }

    public void DisplayError(string error)
    {
        Console.WriteLine(error);
      //  Debug.LogError(error);
    }



    private void Awake()    
        { 
     /*   entryContainer = transform.Find("highscoreEntryContainer");
        entryTemplate = entryContainer.Find("highscoreEntryTemplate");       
        entryTemplate.gameObject.SetActive(false);*/

     /*  // string jsonString = PlayerPrefs.GetString("highscoreTable" + SceneManager.GetActiveScene().name + WordManager.letters);
        FirebaseDatabase.GetJSON("highscoreTable" + SceneManager.GetActiveScene().name + WordManager.letters, gameObject.name, "DisplayData", "DisplayErrorObject");
        Highscores highscores = JsonUtility.FromJson<Highscores>(getData);
        

        if (highscores == null)
        {
            
              // AddHighscoreEntry(0, " ");
             // jsonString = PlayerPrefs.GetString("highscoreTable" + SceneManager.GetActiveScene().name + WordManager.letters);
            // FirebaseDatabase.GetJSON("highscoreTable" + SceneManager.GetActiveScene().name + WordManager.letters, gameObject.name, "DisplayData", "DisplayErrorObject");
           // highscores = JsonUtility.FromJson<Highscores>(getData);
        }

        // Sort entry list by Score
        for (int i = 0; i < highscores.highscoreEntryList.Count; i++)
        {
            for (int j = i + 1; j < highscores.highscoreEntryList.Count; j++)
            {
                if (highscores.highscoreEntryList[j].score > highscores.highscoreEntryList[i].score)
                {
                    // Swap
                    HighscoreEntry tmp = highscores.highscoreEntryList[i];
                    highscores.highscoreEntryList[i] = highscores.highscoreEntryList[j];
                    highscores.highscoreEntryList[j] = tmp;
                }
            }
        }

        highscoreEntryTransformList = new List<Transform>();
        
        foreach (HighscoreEntry highscoreEntry in highscores.highscoreEntryList)
        {
            if (count < 10)
            {
                CreateHighscoreEntryTransform(highscoreEntry, entryContainer, highscoreEntryTransformList);
            }
            count++;
        }*/
    }

   

    private void CreateHighscoreEntryTransform(HighscoreEntry highscoreEntry, Transform container, List<Transform> transformList)
    {
        float templateHeight = 31f;
        Transform entryTransform = Instantiate(entryTemplate, container);
      
     
        RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
        entryRectTransform.anchoredPosition = new Vector2(0, -templateHeight * transformList.Count);
        entryTransform.gameObject.SetActive(true);

        int rank = transformList.Count + 1;
        string rankString;
        switch (rank)
        {
            default:
                rankString = rank + " ."; break;

            case 1: rankString = "1 ."; break;
            case 2: rankString = "2 ."; break;
            case 3: rankString = "3 ."; break;
        }

        entryTransform.Find("posText").GetComponent<Text>().text = rankString;

        int score = highscoreEntry.score;

        entryTransform.Find("scoreText").GetComponent<Text>().text = score.ToString();

        string name = highscoreEntry.name;
        entryTransform.Find("nameText").GetComponent<Text>().text = name;

        // Set background visible odds and evens, easier to read
        entryTransform.Find("background").gameObject.SetActive(rank % 2 == 1);

        // Highlight First
      /*  if (rank == 1)
        {
            entryTransform.Find("posText").GetComponent<Text>().fontStyle = FontStyle.Normal;
            entryTransform.Find("scoreText").GetComponent<Text>().fontStyle = FontStyle.Normal;
            entryTransform.Find("nameText").GetComponent<Text>().fontStyle = FontStyle.Normal;
        }*/
        if (highscoreEntry.name == UserName.name &&highscoreEntry.name != "OYUNCU")
        {
            entryTransform.Find("posText").GetComponent<Text>().color = Color.blue;
            entryTransform.Find("scoreText").GetComponent<Text>().color = Color.blue;
            entryTransform.Find("nameText").GetComponent<Text>().color = Color.blue;
        }

        // Set tropy
        switch (rank)
        {
            default:
                entryTransform.Find("trophy").gameObject.SetActive(false);
                break;
            case 1:
                entryTransform.Find("trophy").GetComponent<Image>().color = Color.yellow;
                break;
            case 2:
                entryTransform.Find("trophy").GetComponent<Image>().color = Color.gray;
                break;
            case 3:
                entryTransform.Find("trophy").GetComponent<Image>().color = Color.white;
                break;
        }
       
        transformList.Add(entryTransform);
    }
    public static string getBetween(string strSource, string strStart, string strEnd)
    {

        int Start, End;
        Start = strSource.IndexOf(strStart, 0) + strStart.Length;
        End = strSource.IndexOf(strEnd, Start);
        return strSource.Substring(Start, End - Start);

    }
    public void AddHighscoreEntry(int score, string name)
    {
        // Create HighscoreEntry
        HighscoreEntry highscoreEntry = new HighscoreEntry { score = score, name = name };
        string json = JsonUtility.ToJson(highscoreEntry);
        FirebaseDatabase.PushJSON("highscoreTable" + SceneManager.GetActiveScene().name + WordManager.letters, json, gameObject.name, "DisplayInfo", "DisplayErrorObject");
        
        FirebaseDatabase.GetJSON("highscoreTable" + SceneManager.GetActiveScene().name + WordManager.letters, gameObject.name, "DisplayData", "DisplayErrorObject");

    }


    public void Reset()
    {
       
     //   PlayerPrefs.DeleteKey("highscoreTable" + SceneManager.GetActiveScene().name + WordManager.letters);
    }

    public  class Highscores
    {
        public List<HighscoreEntry> highscoreEntryList;
    }

    /*
     * Represents a single High score entry
     * */
    [System.Serializable]
    public class HighscoreEntry
    {
        public int score;
        public string name;
    }

}
