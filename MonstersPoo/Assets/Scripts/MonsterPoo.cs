using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterPoo : MonoBehaviour
{
    // Start is called before the first frame update
    //Variables de cada monstruo

    public float comida = 1;
    public float velocidad = 5f;
    public Color color = Color.blue;

    public string[] forma = { "Capsula", "Esfera", "Rectangiulo" };


    private Vector3 targetPosition;// nuevo punto de destino
    public float minDistance = 1f;
    public GameObject muerte;
    private Material material;



    void Start()
    {
        iniciar();
    }

    public void iniciar()
    {
        GenerarPuntoDestino();
        Invoke("Muerte", 4f);
        material = GetComponent<Renderer>().material;

        material.color = color;
    }

    // Update is called once per frame
    void Update()
    {

        movimiento();

    }

    public virtual void movimiento()
    {

        // Verificar si el objeto está cerca del punto objetivo
        if (Vector3.Distance(transform.position, targetPosition) < minDistance)
        {
            // Llegamos al punto, elegir uno nuevo
            GenerarPuntoDestino();
        }
        // Mover hacia el punto objetivo
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, velocidad * Time.deltaTime);

    }

    public void GenerarPuntoDestino()
    {
        // Generar una nueva posición aleatoria en el rango del tablero
        float randomX = Random.Range(-14f, 14f);
        float randomZ = Random.Range(-20f, 20f);
        targetPosition = new Vector3(randomX, 1f, randomZ);
    }

    private void Muerte()
    {
        // Iniciar el sistema de partículas

        Debug.Log("Muerte a los 4 segundos"); 
        Destroy(gameObject);
        Vector3 posicion = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        GameObject GO_muerte= Instantiate(muerte, posicion,Quaternion.identity);

        Muerte sc_muerte = GO_muerte.GetComponent<Muerte>();

        sc_muerte.morir(color);
        
    }
}
