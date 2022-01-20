using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using UnityEngine;

public class KeyboardLayout : MonoBehaviour
{/*
    // API DECLARATIONS
    private const uint KLF_ACTIVATE = 1; // activate the layout
    private const int KL_NAMELENGTH = 9; // length of the keyboard buffer
    public static string keyboardType;
    public static bool isChange=false;
    public static bool isFirst = true;


    [DllImport("user32.dll")]
    private static extern long LoadKeyboardLayout(
    string pwszKLID, // input locale identifier
    uint Flags // input locale identifier options
    );
    [DllImport("user32.dll")]
    private static extern long GetKeyboardLayoutName(
    System.Text.StringBuilder pwszKLID
    );

   
    void Start()
    {
        StringBuilder name = new StringBuilder(KL_NAMELENGTH);
        GetKeyboardLayoutName(name);
        keyboardType = name.ToString();
        if ( !keyboardType.Equals("0001041F"))
        {
            LoadKeyboardLayout("0001041F", KLF_ACTIVATE);
            isChange = true;
        }
        


    }*/
}
