using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class life : MonoBehaviour
{
    Image img;
    public float spawnWait;
    public float startWait;
    private int[] watermelon = new int[5] { 0, 0, 0, 0, 0 };
    // Use this for initialization
    void Start()
    {
        img = GetComponent<Image>();    //获取Image组件
        StartCoroutine(bloodreduce());
        UnityEngineInternal.APIUpdaterRuntimeServices.AddComponent(GameObject.Find("Watermelon_1"), "备注", "HitEat");
        UnityEngineInternal.APIUpdaterRuntimeServices.AddComponent(GameObject.Find("Watermelon_2"), "备注", "HitEat");
        UnityEngineInternal.APIUpdaterRuntimeServices.AddComponent(GameObject.Find("Watermelon_3"), "备注", "HitEat");
        UnityEngineInternal.APIUpdaterRuntimeServices.AddComponent(GameObject.Find("Watermelon_4"), "备注", "HitEat");
        UnityEngineInternal.APIUpdaterRuntimeServices.AddComponent(GameObject.Find("Watermelon_5"), "备注", "HitEat");
    }

    // Update is called once per frame
    void Update()
    {

    }


    IEnumerator bloodreduce()
    {
        yield return new WaitForSeconds(startWait);
        while(img.fillAmount > 0.1f)
        {
            img.fillAmount -= 0.01f;
            yield return new WaitForSeconds(spawnWait);
        }
        
    }
}