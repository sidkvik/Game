using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enableButtons2 : MonoBehaviour
{
    public GameObject menu;
    public GameObject nextLevel;


    void enableButtons1()
    {
        menu.SetActive(true);
        nextLevel.SetActive(true);
    }
    void nextLevel1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    
}
