using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public GameObject main;
    public GameObject controls;
    public GameObject dialogue;


    private void Start()
    {
        main.SetActive(true);
        controls.SetActive(false);
        dialogue.SetActive(false);
    }
    public void stratGame()
    {
        main.SetActive(false);
        controls.SetActive(false);
        dialogue.SetActive(true);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    public void showControlls()
    {
        main.SetActive(false);
        controls.SetActive(true);
    }
    public void backToMain()
    {
        main.SetActive(true);
        controls.SetActive(false);
    }
    public void quitAPP()
    {
        Application.Quit();
    }
  
}
