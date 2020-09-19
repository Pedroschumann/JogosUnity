using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float velocidadeMaxima;
    public float forca;
    public bool IsGrounded;
    public static int lives = 50;
    public Text TextLives;
    public GameObject lastCheckpoint;
    public static int numCoin = 0;
    public Text TextCoin;
    public static bool liberarItem;
    public Transform yAnterior;

    void Start()
    {
        TextLives.text = lives.ToString();
    }

    // Update is called once per frame
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
        }else if (movimento > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }

        //Animacao

        if (movimento > 0 || movimento < 0)
        {
            GetComponent<Animator>().SetBool("andar", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("andar", false);
        }

        //PULAR

        //Seta para Cima
        if (Input.GetKeyDown(KeyCode.UpArrow) && IsGrounded)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector4(0, forca*2));
        }
        //Tecla Espaço
        else if (Input.GetKeyDown(KeyCode.Space) && IsGrounded)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector4(0, forca*2));
        }
        //Tecla W
        else if (Input.GetKeyDown(KeyCode.W) && IsGrounded)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector4(0, forca*2));
        }
        if (IsGrounded)
        {
            GetComponent<Animator>().SetBool("pular", false);
        }else{
            GetComponent<Animator>().SetBool("pular", true);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Verifica Chão
        if (collision.gameObject.CompareTag("Plataforma"))
        {
            IsGrounded = true;
        }

        //Vidas
            //Monstros
        if (collision.gameObject.CompareTag("Monstros"))
        {
            lives--;
            TextLives.text = lives.ToString();
            Vector3 vector3 = transform.position = lastCheckpoint.transform.position;
        }

            //Bloco de Morte
        if (collision.gameObject.CompareTag("Bloco_Morte"))
        {
            lives--;
            TextLives.text = lives.ToString();
            transform.position = lastCheckpoint.transform.position;
        }
            //Moedas
        if (collision.gameObject.CompareTag("Moedas"))
        {
            Destroy(collision.gameObject);
            numCoin ++;
            TextCoin.text = numCoin.ToString();
            if (numCoin == 30)
            {
                liberarItem = true;
            }
        }
        
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Plataforma"))
        {
            IsGrounded = false;
        }
    }

    //Checkpoint

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Checkpoint"))
        {
            lastCheckpoint = collider.gameObject;
        }
    }
}
