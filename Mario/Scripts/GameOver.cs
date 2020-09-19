using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject PainelGameOverCompleto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Game_Over()
    {
        if (Player.lives == 0)
        {
            PainelGameOverCompleto.SetActive(true);
        }
    }
}
