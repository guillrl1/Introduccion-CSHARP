using UnityEngine;

public class Ejercicio8_movimiento : MonoBehaviour {
    public Vector3 moveDirection = new Vector3(0f, 0f, 0f);
        public float speed = 2f;
        public Space mundo = Space.World;
    void Update() {
        // Se multiplica por Time/DeltaTime para que el movimiento sea fluido y no dependa de los FPS del ordenador.
        transform.Translate(moveDirection * speed * Time.deltaTime, mundo);
    }
}
