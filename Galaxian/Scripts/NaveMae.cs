using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NaveMae : MonoBehaviour
{
    public bool lado = false;
    public float speed = 3;
    public static bool destruirCaixa;
    public void Start()
    {
        destruirCaixa = true;
    }
    public void Update()
    {        
        if (transform.position.y > 6.5)
        {
            if (lado == false) 
            {    
                transform.Translate(5 *  -Time.deltaTime, speed *  Time.deltaTime, 0);
            }

            if (lado == true)
            {
                transform.Translate(5 *  Time.deltaTime, speed *  Time.deltaTime, 0);
            }
        }
        if (lado == false) 
        {    
            transform.Translate(8 *  Time.deltaTime, 0, 0);
        }

        if (lado == true)
        {
            transform.Translate(8 *  -Time.deltaTime, 0, 0);
        }

        if (PlayerGalaxian.livesMN == 0)
        {
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("ParedeDireita"))
        {
            lado = false;
        }

        if(collision.gameObject.CompareTag("ParedeEsquerda"))
        {
            lado = true;
        }
    }
}
