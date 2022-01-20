using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    // Start is called before the first frame update
    private float x=0;
    public AudioSource starSound;
    void Start()
    {
        starSound.Play();
        Destroy(this.gameObject, 1.5f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        x += 0.005f;
        
        this.transform.localScale=new Vector3(x,x,x);
       
    }
}
