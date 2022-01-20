using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Usernames : MonoBehaviour
{
    public void Start()
    {

        //Fetch the Dropdown GameObject the script is attached to
        m_Dropdown = GetComponent<TMP_Dropdown>();
        //Clear the old options of the Dropdown menu
        m_Dropdown.ClearOptions();
        //Add the options created in the List above
        ReadTxt();
        m_Dropdown.AddOptions(m_DropOptions);
        header.text = "Oyuncu Ýsmi";
        header.color = Color.black;
    }

    TMP_Dropdown m_Dropdown;
    List<string> m_DropOptions = new List<string> { };
    public Button delButton;
    public TMP_Text if1Text;
    public TMP_Text header;
    public Button addButton;
    public TMP_InputField tmpif;
    // Start is called before the first frame update
    public void ReadTxt()
    {
        string file = "users.txt";
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
            var sr = File.CreateText(file);
            sr.WriteLine("ÝHSAN");
            sr.WriteLine("SITKI");
            sr.WriteLine("YENER");
            sr.Close();
            ReadTxt();
        }
    }


    public void DelUser()
    {
        string file = "users.txt";
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


 
        


    public void AddUsername()
    {
        string inputValue = if1Text.text.ToUpper();

        string file = "users.txt";


        if (File.Exists(file))
            {
                if (inputValue.Length > 1)
                {
                    if (!CheckEnable(inputValue))
                    {
                        File.AppendAllText(file, inputValue + "\n");
                    inputValue = "";
                    tmpif.Select();
                    tmpif.text = inputValue;
                    if1Text.text = inputValue;
                    addButton.gameObject.SetActive(false);
                    Start();

                    m_Dropdown.SetValueWithoutNotify(m_DropOptions.Count - 1);
                }
                else
                {
                    header.text = "Eklenecek Ýsim Listede Var!";
                    header.color = Color.red;
                }
                    
                    
                }
            }
           
           
        




       



    }

    private bool CheckEnable(string iv)
    {
        bool exist = false;
      

        string file = "users.txt";
        if (File.Exists(file))
        {

            var sr = File.OpenText(file);
            var line = "***";

            while (line != null)
            {
                if (line==iv)
                {
                    exist = true;
                    sr.Close();
                    return exist;

                }
                line = sr.ReadLine();

            }

            sr.Close();

        }
        return exist;
    }

    void Update()
    {
        if (m_Dropdown.captionText.text=="ÝHSAN"|| m_Dropdown.captionText.text == "SITKI"|| m_Dropdown.captionText.text == "YENER")
        {
            delButton.gameObject.SetActive(false);

        }
        else
        {
            
            delButton.gameObject.SetActive(true);

        }
    }
}
