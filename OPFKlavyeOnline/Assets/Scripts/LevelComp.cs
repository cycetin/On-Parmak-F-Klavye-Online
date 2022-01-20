using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComp : MonoBehaviour
{
    public GameObject pref;
    public AudioSource buttonFocusSound;
    public AudioSource buttonClickSound;
    public HighscoreTableMain hstm;


    private void Start()
    {
        GameObject newPref = Instantiate(pref, new Vector3(-400, -300, 0), transform.rotation) as GameObject;
        newPref.transform.SetParent(this.transform, false);
        GameObject newPref2 = Instantiate(pref, new Vector3(400, -300, 0), transform.rotation) as GameObject;
        newPref2.transform.SetParent(this.transform, false);
        GameObject newPref3 = Instantiate(pref, new Vector3(-200, -300, 0), transform.rotation) as GameObject;
        newPref3.transform.SetParent(this.transform, false);
        GameObject newPref4 = Instantiate(pref, new Vector3(200, -300, 0), transform.rotation) as GameObject;
        newPref4.transform.SetParent(this.transform, false);

    }
    public void focusSound()
    {
        buttonFocusSound.Play();

    }
    public void clickSound()
    {
        buttonClickSound.Play();
    }
    public void NewUser()

    {

        hstm.AddHighscoreEntry(Spawner.totalSkor, Spawner.username);
        SceneManager.LoadScene("UserInfo");
    }

    public void LoadLevelsScreen()
    {
        SceneManager.LoadScene("Levels");
    }

    public void LoadSameLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void LoadNextLevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void HighscoreScreen()
    {

        SceneManager.LoadScene("Highscore");
    }
    public void Mute()
    {
        AudioListener.pause = !AudioListener.pause;
    }
    public void QuitGame()
    {
       /* if (KeyboardLayout.isChange)
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
