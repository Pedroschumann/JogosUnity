using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Correntes : MonoBehaviour
{
    void Update()
    {
        if (Player.numCoin == 30)
        {
            GetComponent<Animator>().SetBool("quebrando", true);
        }
    }
}
