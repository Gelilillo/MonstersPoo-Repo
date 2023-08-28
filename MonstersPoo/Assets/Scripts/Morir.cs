using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Morir : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject muerte;
    public Color color;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Muerte()
    {
        // Iniciar el sistema de partículas

        Debug.Log("Comidooooo");
        Vector3 posicion = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        GameObject GO_muerte = Instantiate(muerte, posicion, Quaternion.identity);

        Muerte sc_muerte = GO_muerte.GetComponent<Muerte>();
        
        sc_muerte.morir(color);
        Destroy(gameObject);

    }
}
