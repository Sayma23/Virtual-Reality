using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioScript : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioSource audio;
    public GameObject radio;
    void Start()
    {
        radio = GameObject.Find("radio");
        BoxCollider _bc = (BoxCollider)radio.gameObject.AddComponent(typeof(BoxCollider));
        _bc.center = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        
        bool downn = Input.GetMouseButtonDown(0);
        if (downn)
        {
            //Debug.Log("radio script on mouse clicck");
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            //Debug.Log(hit.collider.gameObject.tag);
            if (hit.collider != null)
            {
                Debug.Log(hit.collider.gameObject.name);
                hit.collider.attachedRigidbody.AddForce(Vector2.up);
            }
            else
            {
               // audio.Play(); 
                Debug.Log("nothing");
            }
            /*RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("radio script on mouse clicck" + hit.transform.name); 
                if (hit.transform.name == "radioObject")
                {   Debug.Log("My object is clicked by mouse");
                    if (audio.isPlaying)
                    {

                        audio.Stop();
                    }
                    else
                    {
                        audio.Play();
                    }
                }
            }*/


        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);

        //Debug.Log("should play"); 
        if (audio.isPlaying)
        {
            audio.Stop();
        }
        else
        {
            audio.Play();
        }
        
    }

    /*void OnMouseDown()
    {
        Debug.Log("mouse clicked");
        audio.Play();
    }*/

   
}
