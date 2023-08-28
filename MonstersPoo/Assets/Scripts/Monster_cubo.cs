using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_cubo : MonsterPoo
{
    // Start is called before the first frame update

    private Vector3 targetPosition;// nuevo punto de destino

    private float velocida_giro = 80f; 

    void Start()
    {
        iniciar();
    }

    // Update is called once per frame
    void Update()
    {
        movimiento();
    }
    public override void movimiento() 
    {
        // Verificar si el objeto está cerca del punto objetivo
        if (Vector3.Distance(transform.position, targetPosition) < minDistance)
        {
            // Llegamos al punto, elegir uno nuevo
            GenerarPuntoDestino();
            Debug.Log("Me estoy moviendooooo");
        }
        // Mover hacia el punto objetivo
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, velocidad * Time.deltaTime);
        transform.Rotate(Vector3.right, velocida_giro * Time.deltaTime);

        
    }
    public void GenerarPuntoDestino()
    {
        // Generar una nueva posición aleatoria en el rango del tablero
        float randomX = Random.Range(-14f, 14f);
        float randomZ = Random.Range(-20f, 20f);
        targetPosition = new Vector3(randomX, 1f, randomZ);
    }
}

