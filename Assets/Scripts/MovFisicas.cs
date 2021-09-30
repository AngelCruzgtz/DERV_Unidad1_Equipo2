using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class MovFisicas : MonoBehaviour
{

    int i;
    public float Speed;
    Rigidbody rb;
    int Run;

    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        Speed = 35f;
        Run = 1;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void FixedUpdate()
    {
            
        //Debug.Log("Score: " + i);
            //i++;
        
        if (Input.GetKey(KeyCode.W))
            {
                Debug.Log("Arriba");
                rb.MovePosition(rb.position + transform.forward * Speed * Run * Time.deltaTime);
            }

        
        if (Input.GetKey(KeyCode.A))
            {
                Debug.Log("Izquierda");
                rb.MovePosition(rb.position + transform.right * -1f * Speed * Time.deltaTime);
            }

        
        if (Input.GetKey(KeyCode.S))
            {
                Debug.Log("Atras");
                rb.MovePosition(rb.position + transform.forward * -1 * Speed * Time.deltaTime);
            }

        
        if (Input.GetKey(KeyCode.D))
            {
                Debug.Log("Derecha");
                rb.MovePosition(rb.position + transform.right * Speed * Time.deltaTime);
            }

        
        if (Input.GetKey(KeyCode.Q))
            {
                Debug.Log("Girar Izquierda");
                Quaternion q = Quaternion.Euler(new Vector3(0, -1, 0) * Speed * Time.deltaTime);
                rb.MoveRotation(rb.rotation * q);
            }

        
        if (Input.GetKey(KeyCode.E))
            {
                Debug.Log("Girar Derecha");
                Quaternion q = Quaternion.Euler(new Vector3(0, 1, 0) * Speed * Time.deltaTime);
                rb.MoveRotation(rb.rotation * q);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            Run = 2;
            
        }
        else
        {
            Run = 1;
        }

    }

 }    
    

