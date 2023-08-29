using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ManagerGame : MonoBehaviour
{
    // Start is called before the first frame update

    public int num_monstruos = 50;
    public GameObject[] mousntruos_1;
    public GameObject[] mousntruos_2;

    //Para los mensajes
    public TextMeshPro text_mensaje;
    public Canvas canvas;



    void Start()
    {
        StartCoroutine(Mensaje1());
        crear_monstruos_1();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void crear_monstruos_1()
    {
        for (int i=0; i < num_monstruos; i++)
        {
           int monstruo_sel = Random.Range(0, mousntruos_1.Length);
           Instantiate(mousntruos_1[monstruo_sel], GenerarPuntoOrigen(), Quaternion.identity);

        }

    }
    public Vector3 GenerarPuntoOrigen()
    {
        // Generar una nueva posición aleatoria en el rango del tablero
        float randomX = Random.Range(-14f, 14f);
        float randomZ = Random.Range(-20f, 20f);
        return new Vector3(randomX, 1f, randomZ);
    }
    IEnumerator Mensaje1()
    {
        

        Time.timeScale = 0;
        
        canvas.gameObject.SetActive(true);
        yield return new WaitForSeconds(3f);
        canvas.gameObject.SetActive(false);

    }
   
}
