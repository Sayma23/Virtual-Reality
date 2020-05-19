using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingBottleScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float rightSpeed = 0.05f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * rightSpeed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        //transform.Rotate(Vector3.forward, rightSpeed);
    }

    void RotateBottle()
    {
        for (int i = 0; i < 1000000; i++)
        {
            transform.Translate(Vector3.forward * rightSpeed * Time.deltaTime);
        }
    }
}
