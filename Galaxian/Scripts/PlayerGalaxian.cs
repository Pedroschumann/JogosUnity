using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerGalaxian : MonoBehaviour
{
    public static bool ladoDireito = true;
    public Transform bulletSpawn;
    public float fireRate;
    public float nextFire;
    public GameObject BulletObject;
    public float VelocidadeMaxima;
    public Text TextLives;
    public static int livesMN = 10;
    public Text textlivesNM;
    public GameObject painel;
    public Text textItem;
    public GameObject item;

    void Start()
    {
        TextLives.text = Player.lives.ToString();
        textlivesNM.text = livesMN.ToString();

    }
    void Update()
    {
        float movimento = Input.GetAxis("Horizontal");
        Rigidbody2D rigidbory = GetComponent<Rigidbody2D>();
        rigidbory.velocity = new Vector2(movimento * VelocidadeMaxima, rigidbory.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            Fire();
        }
        if (Tiro.tirarLivesNM)
        {
            textlivesNM.text = livesMN.ToString();
            Tiro.tirarLivesNM = false;
        }
        if (livesMN == 0)
        {
            item.SetActive(true);  
        }
    }
    void Fire()
    {
        nextFire = Time.time + fireRate;
        GameObject cloneBullet = Instantiate(BulletObject, bulletSpawn.position, bulletSpawn.rotation);
    }    
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Medalha"))
        {
            textItem.text = "1";
            painel.SetActive(true);
            Time.timeScale = 0;
            Destroy(other.gameObject);
        }    
    }
    //Vidas
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Tiro Inimigo"))
        {
            Player.lives--; 
            TextLives.text = Player.lives.ToString();
        }
    }
}
