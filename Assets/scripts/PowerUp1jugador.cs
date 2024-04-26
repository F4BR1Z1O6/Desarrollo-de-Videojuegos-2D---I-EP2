using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoAumentoVelocidad : MonoBehaviour
{
    public float aumentoVelocidad = 2f;
    public float duracionAumento = 3f;
    public Color nuevoColor = Color.red;

    //private bool aumentandoVelocidad = false;
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
                jugador.AumentarVelocidad(aumentoVelocidad, duracionAumento, nuevoColor);
            }

            // Destruir este objeto después de la colisión
            Destroy(gameObject);
        }
    }
}