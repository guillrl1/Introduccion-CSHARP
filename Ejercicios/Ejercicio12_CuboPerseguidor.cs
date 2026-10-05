using UnityEngine;

public class CuboPerseguidor : MonoBehaviour {
    public Transform esferaObjetivo;
    public float speed = 5f;

    void Update() {
        if (esferaObjetivo != null) {
            // Único cambio: Rotamos el cubo para que su eje Z positivo (el frente) mire hacia la esfera
            transform.LookAt(esferaObjetivo);
            Vector3 direccion = esferaObjetivo.position - transform.position;
            direccion.y = 0f; 
            direccion = direccion.normalized;

            // Movemos el cubo usando el sistema de referencia mundial (Space.World)
            // Al estar el cubo rotando constantemente con LookAt, 
            // su sistema local (Space.Self) cambia en cada frame.
            transform.Translate(direccion * speed * Time.deltaTime, Space.World);
        }
    }
}