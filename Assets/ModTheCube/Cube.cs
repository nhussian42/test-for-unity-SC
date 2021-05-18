using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public float xPos, yPos, zPos;

    private float elapsedTime;
    
    void Start()
    {
        float randX = Random.Range(-xPos, xPos);
        float randY = Random.Range(-yPos, yPos);
        float randZ = Random.Range(-zPos, zPos);
        float randScale = Random.Range(1.0f, 5.0f);

        transform.position = new Vector3(randX, randY, randZ);
        transform.localScale = Vector3.one * randScale;
        
        Material material = Renderer.material;
        
        material.color = new Color(0.1f, 1.0f, 0.9f, 0.8f);
    }
    
    void Update()
    {
        transform.Rotate(50.0f * Time.deltaTime, 200.0f * Time.deltaTime, 70.0f * Time.deltaTime);
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= 1)
        {
            Invoke("UpdateColor", 1.0f);
            elapsedTime = 0;
        }
    }

    void UpdateColor()
    {
        float R = Random.Range(0.0f, 1.0f);
        float G = Random.Range(0.0f, 1.0f);
        float B = Random.Range(0.0f, 1.0f);
        float A = Random.Range(0.0f, 1.0f);

        Renderer.material.color = new Color(R, G, B, A);
    }
}
