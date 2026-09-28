using UnityEngine;

public class color : MonoBehaviour {
    public int framesWait = 120;
    private float[] vectorColor = new float[3];
    private int framesCount = 0;

    private Renderer objectRenderer;

    void Start() {
        objectRenderer = GetComponent<Renderer>();
        RandomizeColor();
        ApplyColor();
    }

    // Update is called once per frame
    void Update() {
        framesCount++;
        if(framesCount >= framesWait) {
            int randomPos = Random.Range(0, 2);
            vectorColor[randomPos] = Random.Range(0f, 1f);
            ApplyColor();
            framesCount = 0;
        }
    }

    private void ApplyColor() {
        if(objectRenderer != null) {
            Color newColor = new Color(vectorColor[0], vectorColor[1], vectorColor[2]);
            objectRenderer.material.color = newColor;
        }
    }

    private void RandomizeColor() {
         for(int i = 0; i < 3; i++) {
            vectorColor[i] = Random.Range(0f, 1f);
        }
    }
}
