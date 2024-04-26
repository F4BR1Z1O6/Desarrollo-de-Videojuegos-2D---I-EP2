using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoReduccionVelocidad : MonoBehaviour
{
    public float reduccionVelocidad = 2f;
    public float duracionReduccion = 5f;
    public Color nuevoColor = Color.green;

    //private bool reduciendoVelocidad = false;
    private Color colorOriginal;

    void Start()
    {
        colorOriginal = GetComponent<SpriteRenderer>().color;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("JUGADOR"))
        {
            Jugador jugador = col.gameObject.GetComponent<Jugador>();

            if (jugador != null)
            {
                jugador.ReducirVelocidad(reduccionVelocidad, duracionReduccion, nuevoColor);
            }

            // Destruir este objeto después de la colisión
            Destroy(gameObject);
        }
    }
}
