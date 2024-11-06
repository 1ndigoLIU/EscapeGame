using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grey_change_03 : MonoBehaviour
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
        GameObject.Find("chess_red_03").GetComponent<MeshRenderer>().enabled = true;
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        GameObject.Find("chess_red_03").GetComponent<BoxCollider>().enabled = true;
    }
}
