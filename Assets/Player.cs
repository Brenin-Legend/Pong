using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 SpeedVertical;
    public Vector3 SpeedHorizontal;
    public Vector3 SpeedDepth;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position  += SpeedVertical * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= SpeedVertical * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += SpeedHorizontal * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= SpeedHorizontal * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.position += SpeedDepth * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.position -= SpeedDepth * Time.deltaTime;
        }
    }
}
 