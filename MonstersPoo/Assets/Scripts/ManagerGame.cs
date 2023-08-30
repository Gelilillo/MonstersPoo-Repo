using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerGame : MonoBehaviour
{
    // Start is called before the first frame update

    public int num_monstruos_1 = 50;
    public int num_monstruos_2 = 50;
    public GameObject[] mousntruos_1;
    public GameObject[] mousntruos_2;

    //Para los mensajes
    public TMP_Text text_mensaje;
    public TMP_Text text_boton;
    public Canvas canvas;

    private int paso = 1;

    void Start()
    {
        Invoke("Paso1", 1f);
        crear_monstruos(mousntruos_1, num_monstruos_1);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void crear_monstruos(GameObject[] mounstruos,int numero_monstruos)
    {
        for (int i=0; i < numero_monstruos; i++)
        {
           int monstruo_sel = Random.Range(0, mounstruos.Length);
           Instantiate(mounstruos[monstruo_sel], GenerarPuntoOrigen(), Quaternion.identity);

        }

    }
    public Vector3 GenerarPuntoOrigen()
    {
        // Generar una nueva posición aleatoria en el rango del tablero
        float randomX = Random.Range(-14f, 14f);
        float randomZ = Random.Range(-20f, 20f);
        return new Vector3(randomX, 1f, randomZ);
    }
    private void Paso1()
    {
        Time.timeScale = 0;
        text_mensaje.text = "ABSTRACCION: En POO, los objetos son las unidades fundamentales de abstracción. Podemos pensar en ellos como entidades que tienen propiedades (atributos) y pueden realizar acciones (métodos).\n Para este caso se ha creado una clase principal Monstruo con los métodos movimiento y comer entre otros. A continuación puedes ver un numero de objetos con esta clase";
        canvas.gameObject.SetActive(true);

    }
 
    private void Paso2()
    {
        Time.timeScale = 0;
        text_mensaje.text = "HERENCIA: Al crear una clase hija de otra principal, esta clase hija hereda métodos y atributos, para aplicar la herencia se han creado 3 clases hijas de Monstruo diferentes que heredan los métodos y atributos de Monstruo, esto lo podrás ver a continuación representado por los diferentes objetos.";
        canvas.gameObject.SetActive(true);
        // Eliminamos los mosntruos existentes
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("capsula");

        foreach (GameObject obj in objectsWithTag)
        {
            Destroy(obj);
        }
        // crear los monstruos distintos
        crear_monstruos(mousntruos_2,num_monstruos_2);

    }

    private void Paso3()
    {
        Time.timeScale = 0;
        text_mensaje.text = "POLIFORMIESMO: Este te permite cambiar la funcionalidad de lo que un objeto hereda de su clase primaria. En este caso se ha cambiado el metodo del movimiento de los mounstruos cuadrados haciendo que ademas de desplazarse como el resto giren sobre un eje.\n Tambien se ha cambiado en cada clase hija el objeto que comen, de esta forma todos comen y son comidos";
        canvas.gameObject.SetActive(true);

    }

    private void Paso4()
    {
        Time.timeScale = 0;
        text_mensaje.text = "ENCAPSULAMIENTO: es cuando limitamos el acceso o damos un acceso restringido de una propiedad a los elementos que necesita un miembro y no a ninguno más. En la calle principal hay atributos que no se pueden modificar como las coordenadas máximas por donde se mueven.";
        canvas.gameObject.SetActive(true);
        text_boton.text = "Reiniciar";

    }

    public void siguiente_paso()
    {

        canvas.gameObject.SetActive(false);
        Time.timeScale = 1;
        paso++;
        
        {
            if (paso == 5)
            { //este es el ultimo caso para reiniciar
                SceneManager.LoadScene("Juego");
            }
            else
            {
                Invoke("Paso" + paso, 5f);
                Debug.Log("PASO:" + paso);
            }
        }


    }
   
}
