using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "player")
        {
            audioSource.Play();
        }
    }*/

    private void OnCollisionEnter(Collision collider)
    {
        //if (collider.gameObject.tag == "player")
        //{
            audioSource.Play();
        //}
    }
}
