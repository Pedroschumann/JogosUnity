using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInimigos : MonoBehaviour
{
    public GameObject inimigos;
    public GameObject nave_mae;
    public static bool destruir = false;
    public static int spawar2 = 0;
    public static int contagem;
    public int numero;

    void Update()
    {
        numero = contagem;
        if (Tiro.morteInimigos == 10 && Tiro.spawnar == true)
        {
            if (contagem < 1){
                destruir = true;
                spawar2 = 1;
                Tiro.morteInimigos = 0;
                Tiro.spawnar = false;
                GameObject tempPrefab = Instantiate(inimigos) as GameObject;
                tempPrefab.transform.position = new Vector3 (transform.position.x, transform.position.y);
            }
            else if (contagem == 1){
                contagem = 5;
                GameObject tempPrefab = Instantiate(nave_mae) as GameObject;
                tempPrefab.transform.position = new Vector3 (transform.position.x, transform.position.y);
            }
        }
        }
    }
