using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisionesv2 : MonoBehaviour
{
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
        Debug.Log("En Colision con: " + name);

        if (!name.Equals("Player"))
        {
            GameObject gameObject = GameObject.Find(name);

            Destroy(gameObject);
        }
    }
}
