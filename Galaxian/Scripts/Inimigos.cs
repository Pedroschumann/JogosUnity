using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigos : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collisor)
    {
        if(collisor.gameObject.CompareTag("Tiro"))
        {
            Destroy(gameObject);
        }
    }
}
