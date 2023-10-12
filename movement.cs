using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKey("w") || Input.GetKey("s")) 
        {
            if (Input.GetKey("s"))
            {
                transform.Translate(new Vector3(0, Input.GetAxis("Vertical") * 10 * Time.deltaTime, 0));
            } 
            else
            {
                transform.Translate(new Vector3(0, Input.GetAxis("Vertical") * 10 * Time.deltaTime, 0));
            }
        }

        if (Input.GetKey("a") || Input.GetKey("d")) 
        {
            if (Input.GetKey("d"))
            {
                transform.Translate(new Vector3(Input.GetAxis("Horizontal") * 10 * Time.deltaTime, 0 , 0));
            } 
            else
            {
                transform.Translate(new Vector3(Input.GetAxis("Horizontal") * 10 * Time.deltaTime, 0 , 0));
            }
        }
        */
    }

    void FixedUpdate()
    {

         if (Input.GetKey("w") || Input.GetKey("s")) 
        {
            if (Input.GetKey("s"))
            {
                rigidbody.MovePosition(transform.position + new Vector3(0, Input.GetAxis("Vertical") * 10 * Time.deltaTime, 0));
            } 
            else
            {
                rigidbody.MovePosition(transform.position + new Vector3(0, Input.GetAxis("Vertical") * 10 * Time.deltaTime, 0));
            }
        }

        if (Input.GetKey("a") || Input.GetKey("d")) 
        {
            if (Input.GetKey("d"))
            {
                rigidbody.MovePosition(transform.position + new Vector3(Input.GetAxis("Horizontal") * 10 * Time.deltaTime, 0 , 0));
            } 
            else
            {
                rigidbody.MovePosition(transform.position + new Vector3(Input.GetAxis("Horizontal") * 10 * Time.deltaTime, 0 , 0));
            }
        }
    }
}
