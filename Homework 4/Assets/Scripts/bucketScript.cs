using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucketScript : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audioSource;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        audioSource.Play();
    }
}
