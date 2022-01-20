using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsControl : MonoBehaviour
{
    int cout = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnGUI()
    {
        
        Event e = Event.current;
        if (e.capsLock)
        {
            Debug.Log("Caps On "+cout++.ToString());
        }

        

    }
}
