using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Pacman : MonoBehaviour
{
    public float velocidadeMaxima = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        //ANDAR

        Rigidbody2D vetor = GetComponent<Rigidbody2D>();
        float movimento = Input.GetAxis("Horizontal");
        vetor.velocity = new Vector2(movimento * velocidadeMaxima, GetComponent<Rigidbody2D>().velocity.y);

        //VIRAR O PERSONAGEM

        if (movimento < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (movimento > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }
}
