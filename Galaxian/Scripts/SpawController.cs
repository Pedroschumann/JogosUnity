using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawController : MonoBehaviour
{
    public GameObject tiro;
    public float rateSpawn;
    public float currenteTime;
    
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
        }
    }
}
