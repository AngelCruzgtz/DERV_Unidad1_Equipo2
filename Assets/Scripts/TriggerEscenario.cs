using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerEscenario : MonoBehaviour
{
    public TriggerSonido ScriptSonido;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (ScriptSonido.CambioZona) {
            SceneManager.LoadScene(1);
        }
    }
}
