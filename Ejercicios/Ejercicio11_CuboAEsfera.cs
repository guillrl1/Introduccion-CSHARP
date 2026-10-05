using UnityEngine;

public class CuboHaciaEsfera : MonoBehaviour
{
    // Variable para arrastrar la Esfera desde el Inspector
    public Transform esferaObjetivo; 
    public float speed = 5f;

    void Update()
    {
        // Comprobamos que hemos asignado la esfera para evitar errores
        if (esferaObjetivo != null)
        {
            // Calculamos el vector dirección (Destino - Origen)
            Vector3 direccion = esferaObjetivo.position - transform.position;
            // Anulamos el eje Y para que el cubo no modifique su altura
            direccion.y = 0f;
            //longitud a 1
            direccion = direccion.normalized;

            // Aplicamos el movimiento
            // Usamos Space.World porque las posiciones calculadas arriba son globales
            transform.Translate(direccion * speed * Time.deltaTime, Space.World);
        }
    }
}