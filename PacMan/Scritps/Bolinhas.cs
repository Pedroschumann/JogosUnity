using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolinhas : MonoBehaviour
{    
    public static bool isDestroy = false;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
            {
                isDestroy = true;
                Destroy(gameObject);
            }
    }
}
