using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public bool pausado = false;
    public GameObject painel;
    public GameObject painelGameOver;
    public GameObject painelMenu;
    public GameObject painelCredits;
    public GameObject painelTrans;
    public GameObject text1;
    public GameObject text2;
    
    public void OpenCredits()
    {
        painelMenu.SetActive(false);
        painelCredits.SetActive(true);
    }
    public void ClickBack()
    {
        painelCredits.SetActive(false);
        painelMenu.SetActive(true);
    }

    //PAUSE
    void Update()
    {
        if(Input.GetButtonDown("Cancel")){
            pausado = pausar();
        }
        
    }
    public bool pausar(){
        if(Time.timeScale == 0){
            Time.timeScale = 1;
            painel.SetActive(false);
            painelTrans.SetActive(false);
            return(false);

        }else{
            Time.timeScale = 0;
            painel.SetActive(true);
            return(true);
        }

    }
    //GAMEOVER
    public void BotaoPausa(){
        pausado = pausar();
        Debug.Log("PAUSE");
    }
    void FixedUpdate()
    {
        if (Player.lives == 0)
        {
            painelGameOver.SetActive(true);
            Time.timeScale = 0;
        }        
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Play()
    {
        SceneManager.LoadScene("CenaMarioPrototipo");
    }
    public void LevelPacman()
    {
        SceneManager.LoadScene("Pacman");
        
    }
    public void LevelGalaxian()
    {
        SceneManager.LoadScene("CenaGalaxianPrototipo");
    }
}
