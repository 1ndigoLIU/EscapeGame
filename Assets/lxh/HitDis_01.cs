using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDis_01 : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    void OnMouseDown()
    {
        if (gameObject)
        {
            gameObject.GetComponent<AudioSource>().Play();
            GameObject.Find("urn_broken").GetComponent<Renderer>().enabled = true;
            gameObject.GetComponent<Renderer>().enabled = false;
        }
    }
}
