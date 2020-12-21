using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 SpeedVertical;
    public Vector3 SpeedHorizontal;
    public Vector3 SpeedDepth;
    public int PlayerNumber;

    void Start()
    {
        
    }

    void Update()
    {
        if (PlayerNumber == 0)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += SpeedVertical * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.position -= SpeedVertical * Time.deltaTime;
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.position += SpeedVertical * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.position -= SpeedVertical * Time.deltaTime;
            }
        }
    }
}
 