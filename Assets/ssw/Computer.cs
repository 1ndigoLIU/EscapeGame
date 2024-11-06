using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer : MonoBehaviour
{
    // Start is called before the first frame update
    private int num;
    private int[] password;
    private GameObject[] Screen;
    private GameObject Screenp;
    private GameObject Screenw;
    private int pass;

    void Start()
    {
        pass = 0;
        num = -1;
        password = new int[4]{0,0,0,0};
        Screen = new GameObject[5];
        Screen[0] = GameObject.Find("computer/Zero");
        Screen[1] = GameObject.Find("computer/One");
        Screen[2] = GameObject.Find("computer/Two");
        Screen[3] = GameObject.Find("computer/Three");
        Screen[4] = GameObject.Find("computer/Four");
        Screenp = GameObject.Find("computer/Pass");
        Screenw = GameObject.Find("computer/Wrong");
    }

    // Update is called once per frame
    void Update(){
        if(Input.GetKeyDown("0") && num != -1 && pass == 0 && num < 4){
            password[num] = 0;
            Screen[num].GetComponent<CanvasGroup>().alpha = 0;
            Screen[num+1].GetComponent<CanvasGroup>().alpha = 1;
            num++;
        }

        if(Input.GetKeyDown("1") && num != -1 && pass == 0 && num < 4){
            password[num] = 1;
            Screen[num].GetComponent<CanvasGroup>().alpha = 0;
            Screen[num+1].GetComponent<CanvasGroup>().alpha = 1;

            num++;
        }
        if(Input.GetKeyDown("2") && num != -1 && pass == 0 && num < 4){
            password[num] = 2;
            Screen[num].GetComponent<CanvasGroup>().alpha = 0;
            Screen[num+1].GetComponent<CanvasGroup>().alpha = 1;
            num++;
        }
        if(Input.GetKeyDown("3") && num != -1 && pass == 0 && num < 4){
            password[num] = 3;
            Screen[num].GetComponent<CanvasGroup>().alpha = 0;
            Screen[num+1].GetComponent<CanvasGroup>().alpha = 1;
            num++;
        }
        if(Input.GetKeyDown("4") && num != -1 && pass == 0 && num < 4){
            password[num] = 4;
            Screen[num].GetComponent<CanvasGroup>().alpha = 0;
            Screen[num+1].GetComponent<CanvasGroup>().alpha = 1;
            num++;
        }
        if(Input.GetKeyDown("5") && num != -1 && pass == 0 && num < 4){
            password[num] = 5;
            Screen[num].GetComponent<CanvasGroup>().alpha = 0;
            Screen[num+1].GetComponent<CanvasGroup>().alpha = 1;
            num++;
        }
        if(Input.GetKeyDown("6") && num != -1 && pass == 0 && num < 4){
            password[num] = 6;
            Screen[num].GetComponent<CanvasGroup>().alpha = 0;
            Screen[num+1].GetComponent<CanvasGroup>().alpha = 1;
            num++;
        }
        if(Input.GetKeyDown("7") && num != -1 && pass == 0 && num < 4){
            password[num] = 7;
            Screen[num].GetComponent<CanvasGroup>().alpha = 0;
            Screen[num+1].GetComponent<CanvasGroup>().alpha = 1;
            num++;
        }
        if(Input.GetKeyDown("8") && num != -1 && pass == 0 && num < 4){
            password[num] = 8;
            Screen[num].GetComponent<CanvasGroup>().alpha = 0;
            Screen[num+1].GetComponent<CanvasGroup>().alpha = 1;
            num++;
        }
        if(Input.GetKeyDown("9") && num != -1 && pass == 0 && num < 4){
            password[num] = 9;
            Screen[num].GetComponent<CanvasGroup>().alpha = 0;
            Screen[num+1].GetComponent<CanvasGroup>().alpha = 1;
            num++;
        }
        if(num == 4){
            if(password[0] == 7 && password[1] == 4 && password[2] == 2 && password[3] == 9){
                Screen[num].GetComponent<CanvasGroup>().alpha = 0;
                Screenp.GetComponent<CanvasGroup>().alpha = 1;
                pass = 1;

                //pass
                
            }else{
                Screen[num].GetComponent<CanvasGroup>().alpha = 0;
                Screenw.GetComponent<CanvasGroup>().alpha = 1;
            }
        }
        
    }
    void OnMouseDown(){
        if(pass == 0){
            if(num == -1){
            num = 0;
            Screen[0].GetComponent<CanvasGroup>().alpha = 1;
            }else{
                num = -1;
                for(int i = 0;i<5;i++){
                    Screen[i].GetComponent<CanvasGroup>().alpha = 0;
               }
               Screenw.GetComponent<CanvasGroup>().alpha = 0;
               Screenp.GetComponent<CanvasGroup>().alpha = 0;
            }
        }else{
            if(num == -1){
                Screenp.GetComponent<CanvasGroup>().alpha = 1;
                num = 0;
            }else{
                Screenp.GetComponent<CanvasGroup>().alpha = 0;
                num = -1;
            }
        }
        

    }

}
