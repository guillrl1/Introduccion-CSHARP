using UnityEngine;

public class Ejercicio9_movimientoCubo : MonoBehaviour {
    public float speed = 5f;
    // Update is called once per frame
    void Update() {
        float ejeHorizontal = 0;
        float ejeVertical = 0;

        if (Input.GetKey(KeyCode.UpArrow)) {
            ejeVertical = 1f;
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            ejeVertical = -1f;
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            ejeHorizontal = -1f;
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            ejeHorizontal = 1f;
        }

        // Creamos el vector de direccion
        Vector3 direccion = new Vector3(ejeHorizontal, ejeVertical, 0f);
        transform.Translate(direccion * speed * Time.deltaTime);
    }
}
