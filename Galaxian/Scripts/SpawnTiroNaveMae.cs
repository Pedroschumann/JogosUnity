using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTiroNaveMae : MonoBehaviour
{
public GameObject tiro;
    public float rateSpawn;
    public float currenteTime;
    public int num_aleatorio;
    
    void Start()
    {
       currenteTime = 0; 
    }

    void Update()
    {
        currenteTime += Time.deltaTime;
        if (currenteTime >= rateSpawn)
        {
            currenteTime = 0;
            GameObject tempPrefab = Instantiate(tiro) as GameObject;
            tempPrefab.transform.position = new Vector3 (transform.position.x, transform.position.y);
            num_aleatorio = Random.Range(1, 10);
            rateSpawn = rateSpawn + (-num_aleatorio);
            rateSpawn = - rateSpawn;
        }
    }}
