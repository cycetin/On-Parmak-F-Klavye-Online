using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ReadLevels : MonoBehaviour
{

    //Create a List of new Dropdown options
    List<string> m_DropOptions = new List<string> { };
    //This is the Dropdown
    Dropdown m_Dropdown;
    public Button delButton;
    public Toggle regularToggle;
    public TextMeshProUGUI regularText;
    public Toggle lastLetterToogle;
    public TextMeshProUGUI lastLetterText;



    public void DelLevel()
    {
        string file = "Levels.txt";
        if (File.Exists(file))
        {
            m_DropOptions.Clear();
            var sr = File.OpenText(file);
            var line = sr.ReadLine();

            while (line != null)
            {
                if (line != m_Dropdown.captionText.text)
                {
                    m_DropOptions.Add(line);

                }
                line = sr.ReadLine();

            }

            sr.Close();
            var sr2 = File.CreateText(file);
            foreach (string i1 in m_DropOptions)
            {
                sr2.WriteLine(i1);

            }
            sr2.Close();
        }


        Start();






    }

    public void ReadTxt()
    {
        string file = "Levels.txt";
        if (File.Exists(file))
        {
            m_DropOptions.Clear();
            var sr = File.OpenText(file);
            var line = sr.ReadLine();
            while (line != null)
            {
                // Debug.Log(line); // prints each line of the file
                m_DropOptions.Add(line);
                line = sr.ReadLine();

            }
            sr.Close();
        }
        else
        {
            if (File.Exists(file))
            {
                Debug.Log(file + " already exists.");
                return;
            }
            var sr = File.CreateText(file);
            for (int i = 1; i < 31; i++)
            {
                sr.WriteLine(i.ToString());
            }
            sr.Close();
            
            ReadTxt();
        }
    }

    public void Start()
    {
        //Fetch the Dropdown GameObject the script is attached to
        m_Dropdown = GetComponent<Dropdown>();
        //Clear the old options of the Dropdown menu
        m_Dropdown.ClearOptions();
        //Add the options created in the List above
        ReadTxt();
        m_Dropdown.AddOptions(m_DropOptions);
      //  m_Dropdown.SetValueWithoutNotify(m_DropOptions.Count - 1);


    }

    public void SetLast()
    {
        //Fetch the Dropdown GameObject the script is attached to
        m_Dropdown = GetComponent<Dropdown>();
        //Clear the old options of the Dropdown menu
        m_Dropdown.ClearOptions();
        //Add the options created in the List above
        ReadTxt();
        m_Dropdown.AddOptions(m_DropOptions);
          m_Dropdown.SetValueWithoutNotify(m_DropOptions.Count - 1);
    }



    // Update is called once per frame
    void Update()
    {
        int levelss;
        if (int.TryParse(m_Dropdown.options[m_Dropdown.value].text, out levelss))
        {
            delButton.gameObject.SetActive(false);
            regularToggle.gameObject.SetActive(true);
            regularText.gameObject.SetActive(true);
            lastLetterText.gameObject.SetActive(false);
            lastLetterToogle.gameObject.SetActive(false);
        }
        else
        {
            delButton.gameObject.SetActive(true);
            regularToggle.gameObject.SetActive(false);
            regularText.gameObject.SetActive(false);
            lastLetterText.gameObject.SetActive(true);
            lastLetterToogle.gameObject.SetActive(true);
        }

       
    
    }
}
