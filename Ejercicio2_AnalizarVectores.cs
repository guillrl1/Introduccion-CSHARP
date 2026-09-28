using UnityEngine;

public class Ejercicio2 : MonoBehaviour {
    // Declarar en public para poder modificarlos en el inspector
    public Vector3 vectorA = new Vector3(0.0f, 1.0f, 0.0f);
    public Vector3 vectorB = new Vector3(2.0f, 0.5f, 1.0f);

    public float magnitudA;
    public float magnitudB;
    public float angulo;
    public float distancia;
    public string vectorMasAlto;

    void Start() {
        magnitudA = vectorA.magnitude;
        magnitudB = vectorB.magnitude;
        
        angulo = Vector3.Angle(vectorA, vectorB);
        
        distancia = Vector3.Distance(vectorA, vectorB);

        // Comprobamos cuál está a mayor altura 
        if (vectorA.y > vectorB.y) {
            vectorMasAlto = "El Vector A está a mayor altura.";
        }
        else if (vectorB.y > vectorA.y) {
            vectorMasAlto = "El Vector B está a mayor altura."; }
        else {
            vectorMasAlto = "Ambos vectores están a la misma altura.";
        }

        // Mostramos todo en la consola usando Debug.Log
        Debug.Log("Magnitud del Vector A: " + magnitudA);
        Debug.Log("Magnitud del Vector B: " + magnitudB);
        Debug.Log("Ángulo entre los vectores: " + angulo + " grados");
        Debug.Log("Distancia entre ambos: " + distancia);
        Debug.Log(vectorMasAlto);
    }
}
