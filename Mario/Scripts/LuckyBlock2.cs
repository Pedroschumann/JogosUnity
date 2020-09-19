using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuckyBlock2 : MonoBehaviour
{
    public float yNovo = 2.5f;
    public float yAnterior = 1.5f;
    public float novaPosicao = 2.5f;
    public float posicaoAnterior = 1.5f;
    void FixedUpdate()
    {
        if (Player.liberarItem)
        {
            if (Luckyblock.esta_embaixo)
            {
                Transform novaPosicao = GetComponent<Transform>();
                novaPosicao.position = new Vector2(GetComponent<Transform>().position.x, yNovo);
            }
            else
            {
                Transform posicaoAnterior = GetComponent<Transform>();
                posicaoAnterior.position = new Vector2(GetComponent<Transform>().position.x, yAnterior);
            }
        }
    }
}
