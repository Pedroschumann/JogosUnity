using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monstros : MonoBehaviour
{
    public float jumpForce;
    private bool colidde=false;
    private float movimento=-2;
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity=new Vector2(movimento,GetComponent<Rigidbody2D>().velocity.y);
        if (colidde)
        {
            Flip();
        }
    }
    private void Flip()
    {
        movimento *= -1;
        GetComponent<SpriteRenderer>().flipX=!GetComponent<SpriteRenderer>().flipX;
        colidde = false;
    }
    void OnCollisionEnter2D(Collision2D collisor)
    {
        if(collisor.gameObject.CompareTag("Plataforma"))
        {
            colidde = true;
        }
    }
    void CollisionExit2D (Collision2D collisor)
    {
        if(collisor.gameObject.CompareTag("Plataforma"))
        {
            colidde = false;
        }
    }
    void FixedUpdate(){
        if (VerificaMorte.ataque){
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
            movimento = 0;
            BoxCollider2D box = GetComponent<BoxCollider2D>();
            box.isTrigger = true;
            transform.Rotate(new Vector3(0, 0, -180));
            Destroy(gameObject, 2);

        }
    }
}
