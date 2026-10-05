using UnityEngine;

public class Ejercicio7_disparo : MonoBehaviour{
      void Update() {
        if (Input.GetButtonDown("disparo")) {
            Debug.Log("Catapum, te han disparado");
        }
    }
}
