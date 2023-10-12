using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejer_p3 : MonoBehaviour
{
    public float speed;

    public Vector3 moveDirection;

    GameObject sphere;
    Vector3 sphere_direction;

    Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        sphere = GameObject.FindWithTag("green_sphere");
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        sphere_direction = sphere.transform.position - gameObject.transform.position;
        gameObject.transform.LookAt(sphere_direction);
        sphere_direction = sphere_direction.normalized;
        if (Input.GetKey("w") || Input.GetKey("s")) 
        {
            if (Input.GetKey("s"))
            {
                transform.Translate(sphere_direction * Input.GetAxis("Vertical") * speed * Time.deltaTime);
            } 
            else
            {
                transform.Translate(sphere_direction * Input.GetAxis("Vertical") * speed * Time.deltaTime);
            }
        }

        if (Input.GetKey("a") || Input.GetKey("d")) 
        {
            if (Input.GetKey("d"))
            {
                transform.Translate(sphere_direction * Input.GetAxis("Horizontal") * speed * Time.deltaTime);
            } 
            else
            {
                transform.Translate(sphere_direction * Input.GetAxis("Horizontal") * speed * Time.deltaTime);
            }
        }
        */

        /*
        int option = Random.Range(0, 4);
        if (option == 0) 
        {
            transform.Rotate(0, -1, 0);
        }
        else 
        {
            transform.Rotate(0, 1, 0);
        }
        transform.Translate(transform.forward * 10 * Time.deltaTime);
        */       
    }

    void FixedUpdate()
    {
        int option = Random.Range(0, 1);
        if (option == 0) 
        {
            Quaternion delta_rotation = Quaternion.Euler(new Vector3(0, -100, 0) * Time.deltaTime);
            rigidbody.MoveRotation(rigidbody.rotation * delta_rotation);
        }
        else 
        {
            Quaternion delta_rotation = Quaternion.Euler(new Vector3(0, 100, 0) * Time.deltaTime);
            rigidbody.MoveRotation(rigidbody.rotation * delta_rotation);
        }
        rigidbody.MovePosition(transform.position + transform.forward * 10 * Time.deltaTime);
    }
}
