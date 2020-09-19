using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item2 : MonoBehaviour
{
    public Text TextItem2;
    public int NUMERO = 1;
    public static bool destruir = false;
    public GameObject panel;
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
            {
                destruir = true;
                TextItem2.text = NUMERO.ToString();
                Destroy(gameObject);
                panel.SetActive(true);
                Time.timeScale = 0;
            }
    }
}
