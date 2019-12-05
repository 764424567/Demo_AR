using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove : MonoBehaviour
{
    public Transform[] m_Target;
    public float m_MoveSpeed;
    private int i = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, m_Target[i].position, Time.deltaTime * m_MoveSpeed);
        if (transform.position.x >18f)
        {
            i = 0;
        }
        else if (transform.position.x < -18f)
        {
            i = 1;
        }
    }
}
