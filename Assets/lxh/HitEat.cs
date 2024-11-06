using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitEat : MonoBehaviour
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
            Destroy(gameObject);
            GameObject.Find("BLOOD/Canvas/lifeBar").GetComponent<Image>().fillAmount += 0.3f;
        }
    }
}