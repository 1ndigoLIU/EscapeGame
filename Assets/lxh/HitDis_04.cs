using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDis_04 : MonoBehaviour
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
            GameObject.Find("box_close").GetComponent<Animation>().Play();
            Destroy(gameObject.GetComponent<HitDis_04>());
        }
    }
}
