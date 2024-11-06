using UnityEngine;
using System.Collections;
//旋转轴
public enum RotationAxes
{
    MouseXAndY = 0, MouseX = 1, MouseY = 2
}

public class MouseLook : MonoBehaviour
{
    //x轴（水平）速度
    public float sensitivityX = 10F;
    //y轴（垂直）速度
    public float sensitivityY = 10F;
    //x轴（水平）最小旋转值
    public float minimumX = -87F;
    //x轴（水平）最大旋转值
    public float maximumX = 87F;
    //y轴（垂直）最小旋转值
    public float minimumY = -60F;
    //y轴（垂直）最大旋转值
    public float maximumY = 60F;
    //旋转轴
    public RotationAxes axes = RotationAxes.MouseXAndY;
    private float rotationY = 0F;

    void Update()
    {
        if (Input.GetMouseButton(1)){ 
            if (axes == RotationAxes.MouseXAndY)
            {
                float rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityX;

                rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
                rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);

                transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
            }
            else if (axes == RotationAxes.MouseX)
            {
                transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityX, 0);
            }
            else if (axes == RotationAxes.MouseY)
            {
                rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
                rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);

                transform.localEulerAngles = new Vector3(-rotationY, transform.localEulerAngles.y, 0);
            }
        }

    }

    void Start()
    {
        // 确保刚体不改变选转
        if (GetComponent<Rigidbody>())
            GetComponent<Rigidbody>().freezeRotation = true;
    }
}
