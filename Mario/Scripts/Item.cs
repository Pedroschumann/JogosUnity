using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public Text TextItem1;
    public int NUMERO = 1;
    public GameObject novaposicao;
    public GameObject PanelNextLevel;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            {
                TextItem1.text = NUMERO.ToString();
                Destroy(gameObject);
                PanelNextLevel.SetActive(true);
                Time.timeScale = 0;
            }
    }
    void FixedUpdate()
    {
        if (Luckyblock.esta_embaixo && Player.liberarItem) 
        {
            
            BoxCollider2D box = GetComponent<BoxCollider2D>();
            box.isTrigger = false;
            GetComponent<Rigidbody2D>().gravityScale = 1;   
            Vector3 vector3 = transform.position = novaposicao.transform.position;
   
        }
    }
}
