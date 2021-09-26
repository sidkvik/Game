using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enableButtons : MonoBehaviour
{
    public GameObject menuButton;
    public GameObject highSchool;
    public GameObject workExperience;
    public GameObject otherSkills;
    public GameObject languages;
 
    private void Start()
    {
       
        if (GameDialogue.fromWitchLevel == 1f)
        {
            
            highSchool.SetActive(true);
            workExperience.SetActive(false);
            otherSkills.SetActive(false);
            languages.SetActive(false);
        }
        if (GameDialogue.fromWitchLevel == 2f)
        {
            
            highSchool.SetActive(false);
            workExperience.SetActive(true);
            otherSkills.SetActive(false);
            languages.SetActive(false);
        }
        if (GameDialogue.fromWitchLevel == 3f)
        {
           
            highSchool.SetActive(false);
            workExperience.SetActive(false);
            otherSkills.SetActive(true);
            languages.SetActive(false);
        }
        if (GameDialogue.fromWitchLevel == 4f)
        {
          
            highSchool.SetActive(false);
            workExperience.SetActive(false);
            otherSkills.SetActive(false);
            languages.SetActive(true);
        }
    }
    void enableButtons1()
    {
        menuButton.SetActive(true);
       
    }
   

    public void menu1()
    {
        SceneManager.LoadScene(3);
        menuButton.SetActive(false);
    }
}
