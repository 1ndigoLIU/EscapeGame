using UnityEngine;
using System.Collections;

public class HitDestroy : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    void OnMouseDown()
    {
        if(gameObject)
        {
            Destroy(gameObject);
        }
    }
}