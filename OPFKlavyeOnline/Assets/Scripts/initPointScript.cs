using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initPointScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 RandomizeIntensity = new Vector3(0.5f, 0, 0);
    void Start()
    {
        Destroy(gameObject, 0.15f);
        transform.localPosition+=new Vector3(Random.Range(RandomizeIntensity.x,RandomizeIntensity.x*3),
            Random.Range(-RandomizeIntensity.y,RandomizeIntensity.y),
            Random.Range(-RandomizeIntensity.z,RandomizeIntensity.z));
    }

    // Update is called once per frame
  
}
