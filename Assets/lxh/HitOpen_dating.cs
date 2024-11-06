using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitOpen_dating : MonoBehaviour
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
        if (gameObject)
        {
            //GameObject.Find("urn_broken").GetComponent<Renderer>().enabled = true;
            GameObject.Find("doors_dating_close").GetComponent<Animation>().Play();
            Destroy(gameObject.GetComponent<HitOpen_dating>());
            //Destroy(gameObject);
        }
    }
}
