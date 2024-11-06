using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPlateTiny : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    { 
        GameObject.Find("medicine_tiny_under").GetComponent<Renderer>().enabled = true;
        Destroy(gameObject.GetComponent<HitPlateTiny>());
    }
}
