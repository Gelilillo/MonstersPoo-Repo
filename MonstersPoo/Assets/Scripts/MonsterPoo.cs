using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterPoo : MonoBehaviour
{
    // Start is called before the first frame update
    //Variables de cada monstruo

    public float velocidad = 8f;
    

    private Vector3 targetPosition;// nuevo punto de destino
    public float minDistance = 1f;
    public GameObject muerte;
    private Material material;
    private string comida = "cubo";

  



    void Start()
    {
        iniciar();
        cambiar_color(Color.blue);
    }

    public void iniciar()
    {
        GenerarPuntoDestino();

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
        
    void OnTriggerEnter(Collider other)//cuando chocan con otra figura , si es su alimento se lo come.
    {
        if (other.gameObject.tag == comida & other.gameObject.tag != gameObject.tag)
        {

            Debug.Log(gameObject.tag + "se ha comido un " + other.gameObject.tag);

            other.gameObject.GetComponent<Morir>().Muerte();


        }
        

    }
    public void cambiar_comida(string nueva_comida)
    {

        comida = nueva_comida;

    }
    public void cambiar_color(Color nuevo_color)
    {

        material = GetComponent<Renderer>().material;
        material.color = nuevo_color;
    }
    public void comer(Collision other)
    {

        

    }
}
