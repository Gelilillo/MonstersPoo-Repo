using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muerte : MonoBehaviour

{
    // Start is called before the first frame update
    public ParticleSystem particleSystem;
    public Color color;
    void Start()
    {
        

        // Cambia el color de las partículas
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void morir(Color color)
    {

        ParticleSystem.MainModule mainModule = particleSystem.main;
        mainModule.startColor = color;
        particleSystem.Play();


    }
}
