using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ren_move : MonoBehaviour
{
    private Transform m_transform;
    // Start is called before the first frame update
    void Start()
    {
        m_transform = gameObject.GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            m_transform.Translate(Vector3.forward * 0.1f, Space.Self);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            m_transform.Translate(Vector3.left * 0.1f, Space.Self);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            m_transform.Translate(Vector3.back * 0.1f, Space.Self);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            m_transform.Translate(Vector3.right * 0.1f, Space.Self);
        }

    }
}
