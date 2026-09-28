using UnityEngine;

public class CalculadoraDistancias : MonoBehaviour
{
    void Start() {
        // Buscamos las referencias de los GameObjects por su etiqueta
        GameObject cubo = GameObject.FindWithTag("Cube");
        GameObject cilindro = GameObject.FindWithTag("Cylinder");

        // Accedemos al componente Transform de cada uno para obtener su Vector3 position
        Vector3 posicionEsfera = transform.position; // La posición de nuestro objeto actual
        Vector3 posicionCubo = cubo.transform.position;
        Vector3 posicionCilindro = cilindro.transform.position;

        //  Calculamos las distancias
        float distanciaEsferaCubo = Vector3.Distance(posicionEsfera, posicionCubo);
        float distanciaEsferaCilindro = Vector3.Distance(posicionEsfera, posicionCilindro);
        float distanciaCuboCilindro = Vector3.Distance(posicionCubo, posicionCilindro);

        // Mostramos la información en la consola
        Debug.Log("Distancia de la esfera al cubo: " + distanciaEsferaCubo);
        Debug.Log("Distancia de la esfera al cilindro: " + distanciaEsferaCilindro);
        Debug.Log("Distancia entre el cubo y el cilindro: " + distanciaCuboCilindro);
    }
}