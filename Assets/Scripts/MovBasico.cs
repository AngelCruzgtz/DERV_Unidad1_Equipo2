using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovBasico : MonoBehaviour
{

    int i;
    public float Speed;


    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        Speed = 0.4f;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Score: " + i);
        //i++;
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("Arriba");
            transform.Translate(Vector3.forward * Speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Izquierda");
            transform.Translate(Vector3.left * Speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Atras");
            transform.Translate(Vector3.back * Speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Derecha");
            transform.Translate(Vector3.right * Speed);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Salto");
            transform.Translate(Vector3.up * Speed);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            Debug.Log("Girar Izquierda");
            transform.Rotate(new Vector3(0, -1, 0) * Speed);
        }

        if (Input.GetKey(KeyCode.E))
        {
            Debug.Log("Girar Derecha");
            transform.Rotate(new Vector3(0,1,0) * Speed);
        }
    }
}
