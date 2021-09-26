using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour
{


    public GameObject pauseMenuUI;
    public GameObject optionsMenu;


    // Start is called before the first frame update
    void Start()
    {
        pauseMenuUI.SetActive(false);
        optionsMenu.SetActive(false);

        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            GameDialogue.fromWitchLevel = 1;
            Debug.Log("nastaven from witch level na " + GameDialogue.fromWitchLevel);
        }
        if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            GameDialogue.fromWitchLevel = 2;
            Debug.Log("nastaven from witch level na " + GameDialogue.fromWitchLevel);
        }
        if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            GameDialogue.fromWitchLevel = 3;
        }
        if (SceneManager.GetActiveScene().buildIndex == 6)
        {
            GameDialogue.fromWitchLevel = 4;
        }

    }

    void startGame()
    {

    }
}
