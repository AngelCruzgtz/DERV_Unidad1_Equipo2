using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSonido : MonoBehaviour
{
    public AudioSource sonido;
    public bool CambioZona;
    // Start is called before the first frame update
    void Start()
    {
        CambioZona = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        string name = other.gameObject.name;
        Debug.Log("En contacto con: "+name);
        if (name.Equals("Player"))
        {
            CambioZona = true;
            sonido.Play();
        }
    }
}
