using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pacman : MonoBehaviour
{
    public float velocidade;
    public Text TextLives;
    public GameObject lastCheckpoint;
    public int contagem;
    public GameObject item;
    void Start()
    {
        TextLives.text = Player.lives.ToString();    
    }

    void Update()
    {
        //ANDAR

        Rigidbody2D vetor = GetComponent<Rigidbody2D>(); 

        float movimento = Input.GetAxis("Vertical");
        vetor.velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, movimento * velocidade);

        float movimentoDeLado = Input.GetAxis("Horizontal");
        vetor.velocity = new Vector2(movimentoDeLado * velocidade, GetComponent<Rigidbody2D>().velocity.y);

        //VIRAR O PERSONAGEM

        if (movimentoDeLado < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }else if (movimentoDeLado > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }

        //PACDOT
        if (Bolinhas.isDestroy == true){
            contagem++;
            Bolinhas.isDestroy = false;
        }

        if (contagem >= 286 && contagem < 300){
            item.SetActive(true);
        }

    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        //Vidas
            //Monstros
        if (collider.gameObject.CompareTag("Fantasma"))
        {
            Player.lives--;
            TextLives.text = Player.lives.ToString();
            Vector3 vector3 = transform.position = lastCheckpoint.transform.position;
        }
    }
}
