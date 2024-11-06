using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItCon : MonoBehaviour
{
    public Rect rr;
    public Texture[] items = new Texture[12];
    private Rect[] place = new Rect[12] {
        new Rect(68, 638, 60, 60),
        new Rect(148, 638, 60, 60),
        new Rect(228, 638, 60, 60),
        new Rect(308, 638, 60, 60),
        new Rect(388, 638, 60, 60),
        new Rect(468, 638, 60, 60),
        new Rect(548, 638, 60, 60),
        new Rect(628, 638, 60, 60),
        new Rect(708, 638, 60, 60),
        new Rect(788, 638, 60, 60),
        new Rect(868, 638, 60, 60),
        new Rect(948, 638, 60, 60),
    };
    private bool[] packIsEmpty = new bool[10] { true, true, true, true, true, true, true, true, true, true };
    private bool[] itemsExist = new bool[12] { true, true, true, true, true, true, true, true, true, true, true, true };
    private bool[] itemsUsed = new bool[12] { false, false, false, false, false, false, false, false, false, false, false, false };
    private bool[] itemIsInPack = new bool[12] { false, false, false, false, false, false, false, false, false, false, false, false };
    private int[] itemPlace = new int[10] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1};

    private bool door_r2_open = false;
    private bool box_open = false;
    private bool door_dating_open = false;
    private bool selected_0 = false;
    private bool selected_4 = false;
    private bool selected_7 = false;
    private bool selected_9 = false;
    private bool selected_10 = false;

    /*
    0 room1羊皮卷
    1 罐子里钥匙（宝箱
    2 蓝色药水
    3 走廊钥匙（room2
    4 宝箱内羊皮卷
    5 dating钥匙
    6 红色药水
    
    7 大药瓶
    8 黄色药水
    
    
    9 小药瓶
    10 中药瓶
    11 出口钥匙
    */

    // Start is called before the first frame update
    void OnGUI()
    {
        //0 room1羊皮卷
        if (itemsExist[0] == false && itemsUsed[0] == false)
        {
            if (GUI.Button(place[0], items[0]))
            {
                //单击按钮响应内容
                if (selected_0 == false)
                {
                    GameObject.Find("scroll_r1").GetComponent<CanvasGroup>().alpha = 1;
                    selected_0 = true;
                }
                else
                {
                    GameObject.Find("scroll_r1").GetComponent<CanvasGroup>().alpha = 0;
                    selected_0 = false;
                }
            }
        }

        //1 罐子里钥匙（开启宝箱）
        if (itemsExist[1] == false && itemsUsed[1] == false)
        {
            if (GUI.Button(place[1], items[1]))
            {
                //单击按钮响应内容
            }
        }

        //2 蓝色药水
        if (itemsExist[2] == false && itemsUsed[2] == false)
        {
            if (GUI.Button(place[2], items[2]))
            {
                //单击按钮响应内容
                GameObject.Find("blue_state").GetComponent<CanvasGroup>().alpha = 1;
                itemsUsed[2] = true;
            }
        }

        //3 走廊钥匙（room2）
        if (itemsExist[3] == false && itemsUsed[3] == false)
        {
            if (GUI.Button(place[3], items[3]))
            {
                //单击按钮响应内容
            }
        }

        //4 宝箱内羊皮卷
        if (itemsExist[4] == false && itemsUsed[4] == false)
        {
            if (GUI.Button(place[4], items[4]))
            {
                //单击按钮响应内容
                if (selected_4 == false)
                {
                    GameObject.Find("scroll_r2").GetComponent<CanvasGroup>().alpha = 1;
                    selected_4 = true;
                }
                else
                {
                    GameObject.Find("scroll_r2").GetComponent<CanvasGroup>().alpha = 0;
                    selected_4 = false;
                }
            }
        }

        //5 大厅钥匙
        if (itemsExist[5] == false && itemsUsed[5] == false)
        {
            if (GUI.Button(place[5], items[5]))
            {
                //单击按钮响应内容
            }
        }

        //6 红色药水
        if (itemsExist[6] == false && itemsUsed[6] == false)
        {
            if (GUI.Button(place[6], items[6]))
            {
                //单击按钮响应内容
                GameObject.Find("red_state").GetComponent<CanvasGroup>().alpha = 1;
                itemsUsed[6] = true;
            }
        }

        //7 大药瓶
        if (itemsExist[7] == false && itemsUsed[7] == false)
        {
            if (GUI.Button(place[7], items[7]))
            {
                //单击按钮响应内容
                if (selected_7 == false)
                {
                    UnityEngineInternal.APIUpdaterRuntimeServices.AddComponent(GameObject.Find("Plate_big"), "备注", "HitPlateBig");
                    selected_7 = true;
                }
                else
                {
                    Destroy(GameObject.Find("Plate_big").GetComponent<HitPlateBig>());
                    selected_7 = false;
                }
            }
        }

        //8 黄色药水
        if (itemsExist[8] == false && itemsUsed[8] == false)
        {
            if (GUI.Button(place[8], items[8]))
            {
                //单击按钮响应内容
                GameObject.Find("yellow_state").GetComponent<CanvasGroup>().alpha = 1;
                itemsUsed[8] = true;
            }
        }

        //9 小药瓶
        if (itemsExist[9] == false && itemsUsed[9] == false)
        {
            if (GUI.Button(place[9], items[9]))
            {
                //单击按钮响应内容
                if(selected_9 == false)
                {
                    UnityEngineInternal.APIUpdaterRuntimeServices.AddComponent(GameObject.Find("Plate_tiny"), "备注", "HitPlateTiny");
                    selected_9 = true;
                }
                else
                {
                    Destroy(GameObject.Find("Plate_tiny").GetComponent<HitPlateTiny>());
                    selected_9 = false;
                }
                   
            }
        }

        //10 中药瓶        
        if (itemsExist[10] == false && itemsUsed[10] == false)
        {
            if (GUI.Button(place[10], items[10]))
            {
                //单击按钮响应内容
                if (selected_10 == false)
                {
                    UnityEngineInternal.APIUpdaterRuntimeServices.AddComponent(GameObject.Find("Plate_mid"), "备注", "HitPlateMid");
                    selected_10 = true;
                }
                else
                {
                    Destroy(GameObject.Find("Plate_mid").GetComponent<HitPlateMid>());
                    selected_10 = false;
                }
            }
        }

        //11 出口钥匙
        if (itemsExist[11] == false && itemsUsed[11] == false)
        {
            if (GUI.Button(place[11], items[11]))
            {
                //单击按钮响应内容
            }
        }

    }


    // Start is called before the first frame update
    void Start()
    {
        UnityEngineInternal.APIUpdaterRuntimeServices.AddComponent(GameObject.Find("scroll1"), "备注", "HitDestroy");      //00
        //UnityEngineInternal.APIUpdaterRuntimeServices.AddComponent(GameObject.Find("urn"), "备注", "HitDestroy");          //01
        UnityEngineInternal.APIUpdaterRuntimeServices.AddComponent(GameObject.Find("potion_blue"), "备注", "HitDestroy");  //02
        UnityEngineInternal.APIUpdaterRuntimeServices.AddComponent(GameObject.Find("Room2_key"), "备注", "HitDestroy");    //03



        //UnityEngineInternal.APIUpdaterRuntimeServices.AddComponent(GameObject.Find("box"), "备注", "HitDestroy");          //04
        UnityEngineInternal.APIUpdaterRuntimeServices.AddComponent(GameObject.Find("dating_key"), "备注", "HitDestroy");   //05
        UnityEngineInternal.APIUpdaterRuntimeServices.AddComponent(GameObject.Find("potion_red"), "备注", "HitDestroy");   //06
        UnityEngineInternal.APIUpdaterRuntimeServices.AddComponent(GameObject.Find("medicine_big"), "备注", "HitDestroy"); //07
        UnityEngineInternal.APIUpdaterRuntimeServices.AddComponent(GameObject.Find("potion_yellow"), "备注", "HitDestroy");//08
        UnityEngineInternal.APIUpdaterRuntimeServices.AddComponent(GameObject.Find("medicine_tiny"), "备注", "HitDestroy");//09
        UnityEngineInternal.APIUpdaterRuntimeServices.AddComponent(GameObject.Find("medicine_mid"), "备注", "HitDestroy"); //10
        UnityEngineInternal.APIUpdaterRuntimeServices.AddComponent(GameObject.Find("chuqu_key"), "备注", "HitDestroy");    //11
    }

    // Update is called once per frame
    void Update()
    {
        //OnGUI();

        if (!GameObject.Find("scroll1"))
        {
            itemsExist[0] = false;
        }

        if ((GameObject.Find("urn").GetComponent<Renderer>().enabled == false) && box_open == false)    //判断房间二宝箱钥匙已被找到且未添加开箱脚本
        {
            itemsExist[1] = false;
            //为房间二宝箱添加打开脚本
            UnityEngineInternal.APIUpdaterRuntimeServices.AddComponent(GameObject.Find("WoodenChest_small1"), "备注", "HitDis_04");
            //确保脚本只添加一次
            box_open = true;
        }

        if (!GameObject.Find("potion_blue"))
        {
            itemsExist[2] = false;
        }

        if ((!GameObject.Find("Room2_key")) && door_r2_open == false) //判断房间二钥匙已被找到且门未被打开
        {
            itemsExist[3] = false;
            //为房间二门添加开门脚本
            UnityEngineInternal.APIUpdaterRuntimeServices.AddComponent(GameObject.Find("doors_r2_L"), "备注", "HitOpen_r2");
            //确保只添加一次脚本
            door_r2_open = true;
        }

        if (box_open == true && (!GameObject.Find("WoodenChest_small1").GetComponent<HitDis_04>())) //判断宝箱脚本已被添加且打开过
        {
            itemsExist[4] = false;
        }

        if ((!GameObject.Find("dating_key")) && door_dating_open == false)   //判断大厅钥匙已被找到且门未被打开
        {
            itemsExist[5] = false;
            //为大厅门添加开门脚本
            UnityEngineInternal.APIUpdaterRuntimeServices.AddComponent(GameObject.Find("doors_dating_L"), "备注", "HitOpen_dating");
            //确保只添加一次脚本
            door_dating_open = true;
        }

        if (!GameObject.Find("potion_red"))
        {
            itemsExist[6] = false;
        }

        if (!GameObject.Find("medicine_big"))
        {
            itemsExist[7] = false;
        }

        //盘子上出现大药瓶，说明物品已被使用
        if(GameObject.Find("medicine_big_under").GetComponent<Renderer>().enabled == true)
        {
            itemsUsed[7] = true;
        }

        if (!GameObject.Find("potion_yellow"))
        {
            itemsExist[8] = false;
        }

        if (!GameObject.Find("medicine_tiny"))
        {
            itemsExist[9] = false;
        }

        //盘子上出现小药瓶，说明物品已被使用
        if (GameObject.Find("medicine_tiny_under").GetComponent<Renderer>().enabled == true)
        {
            itemsUsed[9] = true;
        }

        if (!GameObject.Find("medicine_mid"))
        {
            itemsExist[10] = false;
        }

        //盘子上出现中药瓶，说明物品已被使用
        if (GameObject.Find("medicine_mid_under").GetComponent<Renderer>().enabled == true)
        {
            itemsUsed[10] = true;
        }

        if (!GameObject.Find("chuqu_key"))
        {
            itemsExist[11] = false;
        }
    }
}
