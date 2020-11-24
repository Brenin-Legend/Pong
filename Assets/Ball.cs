using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Vector3 Speed;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().velocity = Speed;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += Speed * Time.deltaTime;
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Ball collided with {collision.collider.name}");        
    }
}

