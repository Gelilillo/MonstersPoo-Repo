using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerGame : MonoBehaviour
{
    // Start is called before the first frame update

    public int num_monstruos = 50;
    public GameObject[] mousntruos;

    void Start()
    {
        crear_monstruos();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void crear_monstruos()
    {
        for (int i=0; i < num_monstruos; i++)
        {
           int monstruo_sel = Random.Range(0, mousntruos.Length);
           Instantiate(mousntruos[monstruo_sel], GenerarPuntoOrigen(), Quaternion.identity);

        }

    }
    public Vector3 GenerarPuntoOrigen()
    {
        // Generar una nueva posición aleatoria en el rango del tablero
        float randomX = Random.Range(-14f, 14f);
        float randomZ = Random.Range(-20f, 20f);
        return new Vector3(randomX, 1f, randomZ);
    }
}
