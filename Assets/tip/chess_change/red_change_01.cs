﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class red_change_01 : MonoBehaviour
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
        gameObject.GetComponent<BoxCollider>().enabled = false;
        GameObject.Find("chess_grey_01").GetComponent<MeshRenderer>().enabled = true;    
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        GameObject.Find("chess_grey_01").GetComponent<BoxCollider>().enabled = true;
    }
}