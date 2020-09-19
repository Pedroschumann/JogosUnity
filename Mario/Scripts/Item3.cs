using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item3 : MonoBehaviour
{
    public Text TextItem3;

    public int NUMERO = 1;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            {
                TextItem3.text = NUMERO.ToString();
                Destroy(gameObject);
            }
    }
}
