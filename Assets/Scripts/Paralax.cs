using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax : MonoBehaviour
{
    public float speed = 0.1f;
    
    private Material material;
    private Vector2 offset;
    
    void Start()
    {
        material = GetComponent<Renderer>().material;
    }

   
    void Update()
    {
        offset += Vector2.left * speed * Time.deltaTime;
        material.mainTextureOffset = offset;
    }
}
