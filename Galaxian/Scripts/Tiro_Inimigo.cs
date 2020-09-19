using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro_Inimigo : MonoBehaviour
{
    public float y;
    public float speed;
    
    void Update()
    {
        y = transform.position.y;
        y += speed * Time.deltaTime;
        transform.position = new Vector3(transform.position.x, y);

        if (y <= -10)
        {
            Destroy(gameObject);
        }
    }
}
