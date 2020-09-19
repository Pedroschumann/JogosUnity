using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luckyblock : MonoBehaviour
{
    public static bool esta_embaixo;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            esta_embaixo = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            esta_embaixo = false;
        }
    }
}
