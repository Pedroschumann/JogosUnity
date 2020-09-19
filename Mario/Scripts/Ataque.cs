using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ataque : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        void OnCollisionEnter2D(Collision2D collisor)
    {
        if (collisor.gameObject.CompareTag("Monstros"))
        {
            Destroy (gameObject);
        }
    }
}
