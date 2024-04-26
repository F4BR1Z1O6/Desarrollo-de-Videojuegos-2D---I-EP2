using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoResetPosicion : MonoBehaviour
{
    public Vector3 nuevaPosicionJugador = new Vector3((float)-9.39, (float)-4.14, 1);

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("JUGADOR"))
        {
            Jugador jugador = col.gameObject.GetComponent<Jugador>();

            if (jugador != null)
            {
                // Resetear la posición
                jugador.ResetearPosicion(nuevaPosicionJugador);
            }
        }
    }
}
