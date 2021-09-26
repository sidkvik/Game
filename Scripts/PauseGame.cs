using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PauseGame : MonoBehaviour
{
    //GameObject varGameObject = GameObject.Find("Main Camera");

    // public GameObject menu = GameObject.Find("Pause Menu");
    public GameObject pauseMenuUI;
    public GameObject optionsMenu;
    public GameObject miridlo;
    public GameObject gunMenu;
    public GameObject moveMenu;
    public GameObject otherMenu;
    public GameObject nameText;
    public InputField inputF;
    public string jmenoHraceInput;

    

    public InputField input;

    public static bool GameIsPaused = false;


    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Q) || Input.GetButtonDown("Cancel"))
        { 
            if(GameIsPaused)
            {

                
                Resume();
                
            }
            else
            {
                Pause();
                
            }
            //  varGameObject.GetComponent<mouseLook>().enabled = true;
        }

    


}
           public void Resume()
    {
        GameObject.Find("Main Camera").GetComponent<mouseLook>().enabled = true;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        miridlo.SetActive(true);
    }
    void Pause()
    {
        GameObject.Find("Main Camera").GetComponent<mouseLook>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0f;
        pauseMenuUI.SetActive(true);
        miridlo.SetActive(false);
       
        GameIsPaused = true;
    }
  public void LoadMenu()
    {
        pauseMenuUI.SetActive(false);
        optionsMenu.SetActive(true);
        zobrazitGunMenu();

        GameIsPaused = true;
    }
    public void QuitGame()
    {
        Debug.Log("Quitting Game!!");
        Application.Quit();
    }
    public void BackToMainMenu()

    {
        zapisHrace();
        pauseMenuUI.SetActive(true);
        optionsMenu.SetActive(false);
        
    }
  public void zobrazitGunMenu()
    {
        gunMenu.SetActive(true);
        otherMenu.SetActive(false);
        moveMenu.SetActive(false);
    }
    public void zobraziMoveMenu()
    {
        gunMenu.SetActive(false);
        otherMenu.SetActive(false);
        moveMenu.SetActive(true);
    }
    public void zobrazitOtherMenu()
    {

        
        gunMenu.SetActive(false);
        otherMenu.SetActive(true);
        moveMenu.SetActive(false);
        zapisHrace();
    }
    //This takes value from input field and save it to JmenoHrace
    public void zapisHrace()
    {
     input.GetComponent<InputField>();
     input.onEndEdit.AddListener(SubmitName);
    }
    private void SubmitName(string arg0)
    {
        Debug.Log(arg0);
        jmenoHraceInput = arg0;
        Debug.Log(jmenoHraceInput);
        
        DialogueManager.jmenoHrace = jmenoHraceInput;
        jmenoHraceInput = DialogueManager.jmenoHrace;
        Debug.Log(DialogueManager.jmenoHrace);
    }
}
