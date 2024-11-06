using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorsUnderOpen : MonoBehaviour
{

    private bool door_close = true;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("medicine_big_under").GetComponent<Renderer>().enabled == true &&
            GameObject.Find("medicine_mid_under").GetComponent<Renderer>().enabled == true &&
            GameObject.Find("medicine_tiny_under").GetComponent<Renderer>().enabled == true &&
            door_close)
        {
            gameObject.GetComponent<Animation>().Play();
            door_close = false;
        }
    }
}
