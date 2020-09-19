using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tiro : MonoBehaviour
{
    public float speed;
    public float timeDestroy;
    public static int morteInimigos;
    public static bool spawnar;
    public static bool tirarLivesNM = false;
    void Start()
    {
        timeDestroy = 1.5f;
        Destroy(gameObject, timeDestroy);
        transform.Rotate(new Vector3 (0,0, 90));
    }

    void Update()
    {
        transform.Translate(Vector2.left * -speed * Time.deltaTime);
    }
    void OnCollisionEnter2D (Collision2D collisor)
    {
        if (collisor.gameObject.CompareTag("Inimigos"))
        {
            morteInimigos += 1;
            spawnar = true;
            Destroy(gameObject);
        }
        else if (collisor.gameObject.CompareTag("Nave Mãe"))
        {
            morteInimigos += 1;
            spawnar = true;
            PlayerGalaxian.livesMN --;
            tirarLivesNM = true;
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject, 3f);
        }
    }
}
