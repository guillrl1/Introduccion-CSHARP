using UnityEngine;

public class MovimientoZ : MonoBehaviour
{
    public float velocidadAvance = 5f;
    public float velocidadGiro = 100f;

    void Update()
    {
        // Leemos el eje Horizontal para el giro (Izquierda/Derecha o A/D)
        float giro = Input.GetAxis("Horizontal");

        // Aplicamos la rotación en el eje Y (el eje vertical sobre el que pivota el objeto)
        transform.Rotate(0f, giro * velocidadGiro * Time.deltaTime, 0f);

        // Avanzamos siempre en la dirección hacia adelante del propio objeto
        // Como transform.forward ya es una dirección en el espacio mundial, usamos Space.World
        transform.Translate(transform.forward * velocidadAvance * Time.deltaTime, Space.World);

        // Dibujamos un rayo de depuración 
        Debug.DrawRay(transform.position, transform.forward * 3f, Color.red);
    }
}