using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterPoo2 : MonsterPoo
{
    // Start is called before the first frame update
    void Start()
    {
        iniciar();
        cambiar_comida("capsula");
        cambiar_color(Color.red);
    }

    // Update is called once per frame
    void Update()
    {
        movimiento();
    }
}
