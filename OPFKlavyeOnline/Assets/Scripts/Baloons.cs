using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baloons : MonoBehaviour
{
    private float x = 0;
    
    void Start()
    {
        
        Destroy(this.gameObject, 5f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        x += 0.08f;
        if (x<2)
        {
            this.transform.localScale = new Vector3(x, x, x);
        }
       // this.transform.localScale = new Vector3(x, x, x);
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + x, this.transform.position.z);

    }
}
