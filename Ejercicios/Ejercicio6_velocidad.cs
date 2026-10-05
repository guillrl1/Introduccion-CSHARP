using UnityEngine;

public class Ejercicio6_velocidad : MonoBehaviour {
    public float velocidad = 10f;

    void Update() {
        // Los valores van de 1 a -1
        float ejeHorizontal = Input.GetAxis("Horizontal");
        float ejeVertical = Input.GetAxis("Vertical");

        float resultado = velocidad * ejeVertical * ejeHorizontal;

        if (Input.GetKey(KeyCode.UpArrow)) {
            Debug.Log("Flecha Arriba: " + resultado);
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            Debug.Log("Flecha Abajo: " + resultado);
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            Debug.Log("Flecha Izquierda: " + resultado);
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            Debug.Log("Flecha Derecha: " + resultado);
        }
    }
}
