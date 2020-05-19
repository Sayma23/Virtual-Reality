using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeMugScript : MonoBehaviour
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

    private void OnCollisionEnter(Collision collision)
    {
        audioSource.Play();
    }
}
