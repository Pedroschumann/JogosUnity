using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fundo : MonoBehaviour
{
    private Material currenteMaterial;
    public float speed;
    private float offset;

    void Start()
    {
        currenteMaterial = GetComponent<SpriteRenderer>().material;
    }

    void Update()
    {
        offset += 0.001f;
        currenteMaterial.SetTextureOffset("_MainTex", new Vector2(offset*speed, 0));
    }
}
