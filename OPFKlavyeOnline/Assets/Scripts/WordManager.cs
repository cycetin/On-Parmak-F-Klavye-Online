using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WordManager : MonoBehaviour
{
    public GameObject shapePrefab;
    public Transform wordCanvas;
    private GameObject wordObj;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI skorText;
    public TextMeshProUGUI trueCountText;
    public TextMeshProUGUI falseCountText;
    public TextMeshProUGUI missCountText;
    public TextMeshProUGUI initialTrueCountText;
    public TextMeshProUGUI initialFalseCountText;
    public TextMeshProUGUI initialMissCountText;
    public TextMeshProUGUI initialLevelUpTrueCountText;
    public TextMeshProUGUI initialLevelUpFalseCountText;
    public TextMeshProUGUI initialLevelUpMissCountText;
    public TextMeshProUGUI initialLevelUpSkorCountText;
    public TextMeshProUGUI totalSkorText;
    public TextMeshProUGUI levelUI;

    public TextMeshProUGUI levelUpUserName;
    public TextMeshProUGUI levelUpLevel;
    public TextMeshProUGUI levelUpTime;
    public TextMeshProUGUI levelUpAverage;

    public AudioSource trueWordSound;
    public AudioSource wrongKeySound;
    public AudioSource levelCompleteSound;
    public AudioSource explosionSound;


    static public string letters = "0";
    private string intenseLetter;
    private int counter = 0;
    public int currentWord = 1;
    private GameObject explosion;
    public GameObject settingsScreen;
    public static List<GameObject> lettersOnProcess = new List<GameObject>();
    private int skor = 0;
    static public int level = 1;    
    public Button startButton;
    public bool isStart = false;
    public Dropdown levelDrop;
    public Dropdown timeDrop;
    public InputField wpmInput;
    float totalTime;
    float wpm;
    public Toggle regularGame;
    public Toggle lastLetter;
    public Toggle fingerGuide;
    public Toggle muteToogle;
    public Button fingersOnButton;
    public Button fingersOffButton;    
    bool isRegularGame;
    public GameObject levelUpScreen;
    public GameObject leftHand;
    public GameObject rightHand;   
    private int iTrueCount = 0;
    private int iFalseCount = 0;
    private int iMissCount = 0;
    public HighscoreTable hst;
    
  

   
        




    public void RestartLevel()
    {
         
        lettersOnProcess.Clear();
        UserName.userPoint = UserName.userPoint + skor;        
        Time.timeScale = 1;
        Resources.UnloadUnusedAssets();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
       
    }



   




    public void BackScreen()
    {
        SceneManager.LoadScene("Levels");
    }

    public void MainMenu()
    {
     
        lettersOnProcess.Clear();
        UserName.userPoint = UserName.userPoint + skor;        
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }
    private void Start()
    {
        if (AudioListener.pause)
        {
            muteToogle.isOn = true;
            AudioListener.pause = !AudioListener.pause;
        }
        else
        {
            muteToogle.isOn = false;
           
        }
        
        
    }

    public void startGame(int level)
    {

      

        isRegularGame = regularGame.isOn;
        if (wpmInput.text.Length == 0)
        {
            wpm = 60.0f;
            
        }
        else
        {
            wpm = float.Parse(wpmInput.text);
        }

        if (wpm < 60.0f || wpm > 300.0f)
        {
            wpm = 60.0f;
        }
        totalTime = int.Parse(timeDrop.options[timeDrop.value].text) * 60f;

        if (int.TryParse(levelDrop.options[levelDrop.value].text, out level))
        {
            level = int.Parse(levelDrop.options[levelDrop.value].text);
        }
        else
        {
            level = 0;
        }

        ChooseStart(level);
        isStart = true;

    }
    private void ChooseStart(int level)
    {
            iTrueCount = 0;
            iFalseCount = 0;
            iMissCount = 0;
            levelUI.text = level.ToString();
        
        switch (level)
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
    }


 


 
    private void Update()
    {
        if (fingerGuide.isOn)
        {
            leftHand.SetActive(true);
            rightHand.SetActive(true);
            fingersOnButton.gameObject.SetActive(false);
            fingersOffButton.gameObject.SetActive(true);
        }
        else
        {
            leftHand.SetActive(false);
            rightHand.SetActive(false);
            fingersOnButton.gameObject.SetActive(true);
            fingersOffButton.gameObject.SetActive(false);
        }
       

        if (levelUI.text != "0")
        {
            level = int.Parse(levelUI.text);
        }
        if (isStart)
        {
            totalTime -= Time.deltaTime;
            UpdateLevelTimer(totalTime);
            if (totalTime <= 0)
            {
                for (int i = 0; i < lettersOnProcess.Count; i++)
                {
                    if (lettersOnProcess[i] != null)
                    {
                        DeleteWord(lettersOnProcess[i].name);
                        UserName.missCount++;
                        iMissCount++;
                        skor--;
                        explosionSound.Play();
                    }

                }
                UserName.userLevel = UserName.userLevel + 1;
                
                              
               
                if (isRegularGame)
                {
                    hst.AddHighscoreEntry(skor, UserName.name);
                    levelUP();
                    WordTimer.wordPerMinute = wpm;
                }
                else
                {

                    if (levelUI.text == "0")
                    {                       
                       // skor = 0;
                    }
                    trueCountText.text = UserName.trueCount.ToString();
                    falseCountText.text = UserName.falseCount.ToString();
                    missCountText.text = UserName.missCount.ToString();                   
                    totalSkorText.text = (UserName.userPoint+skor).ToString();


                    initialLevelUpTrueCountText.text ="+"+ iTrueCount.ToString();
                    initialLevelUpFalseCountText.text = "+" + iFalseCount.ToString();
                    initialLevelUpMissCountText.text = "+" + iMissCount.ToString();


                    if (skor<0)
                    {
                        initialLevelUpSkorCountText.text =skor.ToString();
                        initialLevelUpSkorCountText.color = Color.red;
                    }
                    else if (skor>0)
                    {
                        initialLevelUpSkorCountText.text = "+" + skor.ToString();
                        initialLevelUpSkorCountText.color = Color.green;
                    }
                    else
                    {
                        initialLevelUpSkorCountText.text = "+" + skor.ToString();
                        initialLevelUpSkorCountText.color = Color.white;
                    }
                    
                    levelUpUserName.text = UserName.name.ToUpper();
                    levelUpLevel.text = levelUI.text;
                    levelUpTime.text = timeDrop.captionText.text;
                    float average = float.Parse(initialLevelUpSkorCountText.text) / float.Parse(timeDrop.captionText.text);
                    levelUpAverage.text = average.ToString("F2");
                    hst.AddHighscoreEntry(skor, UserName.name);
                   
                    
                    levelUpScreen.gameObject.SetActive(true);                
                  
                        
                        levelCompleteSound.Play();
                                    
                    totalTime = 0;
                    isStart = false;
                    if (levelUI.text == "0")
                    {
                        skor = 0;
                    }
                   
                    
                   

                }

                
                
              

            }


            skorText.text = skor.ToString();
            initialTrueCountText.text = iTrueCount.ToString();
            initialFalseCountText.text = iFalseCount.ToString();
            initialMissCountText.text = iMissCount.ToString();
            try
            {
                if (lettersOnProcess.Count != 0)
                {
                    //Burası olmalı
                    lettersOnProcess[currentWord - 1].GetComponent<TextMesh>().color = Color.black;
                    ShowFinger(lettersOnProcess[currentWord - 1].GetComponent<TextMesh>().text);
                    //leftHand.gameObject.GetComponent<Image>().sprite = Resources.Load(imageName, typeof(Sprite)) as Sprite;


                }
                if (lettersOnProcess.Count != 0 && lettersOnProcess[currentWord - 1].transform.position.y <= -2)
                {
                    explosion = Resources.Load<GameObject>("Patlama0");
                    DeleteWord(lettersOnProcess[currentWord - 1].name);
                    skor--;
                    UserName.missCount++;
                    iMissCount++;
                    explosionSound.Play();
                    

                }
                if (Input.anyKeyDown && Input.inputString.ToUpper() == lettersOnProcess[currentWord - 1].GetComponent<TextMesh>().text)
                {
                    explosion = Resources.Load<GameObject>("Patlama" + UnityEngine.Random.Range(1, 5).ToString());
                    DeleteWord(lettersOnProcess[currentWord - 1].name);
                    skor++;
                    UserName.trueCount++;
                    iTrueCount++;
                    trueWordSound.Play();

                }
                else if (!(Input.GetKey(KeyCode.Mouse0) || Input.GetKey(KeyCode.Mouse1)||Input.GetKey(KeyCode.Escape)) &&Input.anyKeyDown && Input.inputString.ToUpper() != lettersOnProcess[currentWord - 1].GetComponent<TextMesh>().text)
                {
                    skor--;
                    UserName.falseCount++;
                    iFalseCount++;
                    wrongKeySound.Play();
                }
            }
            catch (ArgumentOutOfRangeException)
            {


            }


        }


    }

    private void ShowFinger(string letter)
    {
        string imageName="";
        if (letter == "A" || letter == "I" || letter == "O" || letter == "Ü" || letter == "C" || letter == "Ç"||letter=="4"||letter=="5") 
        {
            imageName = "leftone";
            leftHand.gameObject.GetComponent<Image>().sprite = Resources.Load(imageName, typeof(Sprite)) as Sprite;
            rightHand.gameObject.GetComponent<Image>().sprite = Resources.Load("righthandempty", typeof(Sprite)) as Sprite;
        }
        if (letter == "K" || letter == "T" || letter == "Z" || letter == "S" || letter == "D" || letter == "R"||letter=="6"||letter=="7")
        {
            imageName = "rightone";
            rightHand.gameObject.GetComponent<Image>().sprite = Resources.Load(imageName, typeof(Sprite)) as Sprite;
            leftHand.gameObject.GetComponent<Image>().sprite = Resources.Load("lefthandempty", typeof(Sprite)) as Sprite;
        }
        if (letter == "Ğ" || letter == "E" || letter == "V"||letter=="3")
        {
            imageName = "lefttwo";
            leftHand.gameObject.GetComponent<Image>().sprite = Resources.Load(imageName, typeof(Sprite)) as Sprite;
            rightHand.gameObject.GetComponent<Image>().sprite = Resources.Load("righthandempty", typeof(Sprite)) as Sprite;
        }
        if (letter == "N" || letter == "M" || letter == "B" || letter == "8" )
        {
            imageName = "righttwo";
            rightHand.gameObject.GetComponent<Image>().sprite = Resources.Load(imageName, typeof(Sprite)) as Sprite;
            leftHand.gameObject.GetComponent<Image>().sprite = Resources.Load("lefthandempty", typeof(Sprite)) as Sprite;
        }

        if (letter == "G" || letter == "İ" || letter == "Ö" || letter == "2")
        {
            imageName = "leftthree";
            leftHand.gameObject.GetComponent<Image>().sprite = Resources.Load(imageName, typeof(Sprite)) as Sprite;
            rightHand.gameObject.GetComponent<Image>().sprite = Resources.Load("righthandempty", typeof(Sprite)) as Sprite;
        }
        if (letter == "H" || letter == "L" || letter == "9" || letter == "8")
        {
            imageName = "rightthree";
            rightHand.gameObject.GetComponent<Image>().sprite = Resources.Load(imageName, typeof(Sprite)) as Sprite;
            leftHand.gameObject.GetComponent<Image>().sprite = Resources.Load("lefthandempty", typeof(Sprite)) as Sprite;
        }

        if (letter == "1" || letter == "F" || letter == "U" || letter == "J" )
        {
            imageName = "leftfour";
            leftHand.gameObject.GetComponent<Image>().sprite = Resources.Load(imageName, typeof(Sprite)) as Sprite;
            rightHand.gameObject.GetComponent<Image>().sprite = Resources.Load("righthandempty", typeof(Sprite)) as Sprite;
        }
        if (letter == "0" || letter == "P" || letter == "Q" || letter == "W" || letter == "Y" || letter == "Ş" || letter == "X"||letter=="."||letter=="," )
        {
            imageName = "rightfour";
            rightHand.gameObject.GetComponent<Image>().sprite = Resources.Load(imageName, typeof(Sprite)) as Sprite;
            leftHand.gameObject.GetComponent<Image>().sprite = Resources.Load("lefthandempty", typeof(Sprite)) as Sprite;
        }


    }

    public void Mute()
    {
        AudioListener.pause = !AudioListener.pause;     

    }

    public void PauseSettings()
    {
        wpmInput.text = wpm.ToString();
        //timeDrop.captionText.text = totalTime.ToString();
        levelDrop.captionText.text = level.ToString();
    }
    
    

    public void levelUP()
    {
       // totalSkor += skor;
        //hst.AddHighscoreEntry(skor, UserName.name);
        skor = 0;
        totalTime = int.Parse(timeDrop.options[timeDrop.value].text) * 60f;
        wpm += 8;
        level += 1;
        ChooseStart(level);
        isStart = true;

    }

    public void again()
    {

        

            if (levelUI.text == "0")
            {

                skor = 0;
                totalTime = int.Parse(timeDrop.options[timeDrop.value].text) * 60f;
                ChooseStart(0);
                isStart = true;

            }
            else
            {

                skor = 0;
                totalTime = int.Parse(timeDrop.options[timeDrop.value].text) * 60f;
                ChooseStart(level);
                isStart = true;
            }

        
    }

    public void UpdateLevelTimer(float totalSeconds)
    {
        int minutes = Mathf.FloorToInt(totalSeconds / 60f);
        int seconds = Mathf.RoundToInt(totalSeconds % 60f);
        string formatedSeconds = seconds.ToString();

        if (seconds == 60)
        {
            seconds = 0;
            minutes += 1;
        }

        timerText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
        if (totalSeconds<=10)
        {
            timerText.color = Color.red;  
        }
        else
        {
            timerText.color = Color.yellow;           
        }
    }

 

    public void AddWord()
    {
        wordObj = Instantiate(shapePrefab, transform.position, Quaternion.identity, wordCanvas);
        wordObj.GetComponent<FallingWordPref>().startFalling(wpm);
        intenseLetter = letters[letters.Length - 1].ToString();
        wordObj.name = (++counter).ToString();
        // wordObj.GetComponent<TextMesh>().text = (counter).ToString(); ;        
        lettersOnProcess.Add(wordObj);
       

        if (levelUI.text == "0" & lastLetter.isOn == true)
        {
            if (UnityEngine.Random.Range(0, 4) > 0)
            {
                wordObj.GetComponent<TextMesh>().text = letters[UnityEngine.Random.Range(0, letters.Length - 1)].ToString();
            }
            else
            {
                wordObj.GetComponent<TextMesh>().text = intenseLetter;

            }
        }
        else if (levelUI.text == "0" & lastLetter.isOn == false)
        {
            wordObj.GetComponent<TextMesh>().text = letters[UnityEngine.Random.Range(0, letters.Length)].ToString();
        }
        else
        {

            if (level == 1)
            {
                wordObj.GetComponent<TextMesh>().text = letters[UnityEngine.Random.Range(0, letters.Length)].ToString();
            }
            else
            {
                if (UnityEngine.Random.Range(0, 4) > 0)
                {
                    wordObj.GetComponent<TextMesh>().text = letters[UnityEngine.Random.Range(0, letters.Length-1)].ToString();
                }
                else
                {
                    wordObj.GetComponent<TextMesh>().text = intenseLetter;

                }
            }
        }





    }

    public void DeleteWord(string name)
    {


        for (int i = 0; i < lettersOnProcess.Count; i++)
        {
            if (lettersOnProcess[i] != null && lettersOnProcess[i].name == name)
            {

                Instantiate(explosion, lettersOnProcess[i].transform.position, transform.rotation = Quaternion.identity);
                GameObject willDel = lettersOnProcess[i];
                lettersOnProcess[i] = null;
                Destroy(willDel);
                break;
            }
        }

        

        currentWord += 1;
    }


    public void QuitGame()
    {
     /*   if (KeyboardLayout.isChange)
        {
            KeyboardLayout.isFirst = false;
            SceneManager.LoadScene(1);
        }
        else
        {
            Application.Quit();
        }*/
       
    }

}
