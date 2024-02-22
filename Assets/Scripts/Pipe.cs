using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float speed = 1;
    
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x <= -2.3f)
        {
            var y = Random.Range(-1.5f, 1.5f);
            var x = Random.Range(4.2f, 4.5f);
            
            transform.position = new Vector3(x, y, 0);
            
        }
    }
}
