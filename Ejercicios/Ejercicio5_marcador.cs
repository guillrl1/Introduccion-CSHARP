using UnityEngine;

public class Ejercicio6_ : MonoBehaviour
{
    // Variable pública para configuar el desplazamiento
    public Vector3 desplazamiento;

    private Vector3 posicionOriginal;
    
    void Start() {
        posicionOriginal = transform.position;
    }

    // Update is called once per frame
    void Update() {
        // la barra espaciadora está asociada por defecto a la acción "jump"
        if (Input.GetAxis("Jump") > 0) {
           transform.position = posicionOriginal + desplazamiento;
        }
    }
}
