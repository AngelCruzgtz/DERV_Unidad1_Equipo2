using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Colisiones : MonoBehaviour
{
    public TextMeshProUGUI Txt_mensaje;


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
        string name = collision.gameObject.name;
        Debug.Log("En Colision con :" + name);

        if (name.Equals("Veterinario"))
        {
            Txt_mensaje.text = "Veterinario: Hola, ¿Como está tu perro?";
        }
        else if (name.Equals("Persona1"))
        {
            Txt_mensaje.text = "Persona 1: Ey tu! ¿Que haces en mi casa?";
        }
        else if (name.Equals("Persona2"))
        {
            Txt_mensaje.text = "Persona 2: Hola, soy nuevo en el vecindario, ¿quieres ser mi amigo?";
        }
        else if (name.Equals("Perro"))
        {
            Txt_mensaje.text = "Perro : Gauf... (Estas arrepentido???)";
        }


    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Se mantiene la Colisión");
    }

    private void OnCollisionExit(Collision collision)
    {
        //Debug.Log("Sale de la Colisión");
        Txt_mensaje.text = "";
    }
}
