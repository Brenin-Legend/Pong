using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position  += Speed * Time.deltaTime;
        }

    
   
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= Speed * Time.deltaTime;
        }

    }
   

}
 