using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsMenuManager : MonoBehaviour
{
    public GameObject levelFinished;
    public GameObject levelFinished1;
    public GameObject levelFinished2;
    public GameObject levelFinished3;
    public GameObject playButton;
    public GameObject playButton1;
    public GameObject playButton2;
    public GameObject playButton3;
    public GameObject rawImage;
    public GameObject rawImage1;
    public GameObject rawImage2;
    public void showFinishedLEvels()
    {
        if (GameDialogue.finishedLevels[0] == true)
        {
            levelFinished.SetActive(true);
            playButton.SetActive(true);
            playButton1.SetActive(true);
            rawImage.SetActive(true);
        }
        if (GameDialogue.finishedLevels[1] == true)
        {
            levelFinished1.SetActive(true);
            playButton2.SetActive(true);
            rawImage1.SetActive(true);
        }
        if (GameDialogue.finishedLevels[2] == true)
        {
            levelFinished2.SetActive(true);
            playButton3.SetActive(true);
            rawImage2.SetActive(true);
        }
        if (GameDialogue.finishedLevels[3] == true)
        {
            levelFinished3.SetActive(true);
           
        }
    }
    public void playLevel1()
    {
        SceneManager.LoadScene(1);
    }
    public void playLevel2()
    {
        SceneManager.LoadScene(4);
    }
    public void playLevel3()
    {
        SceneManager.LoadScene(5);
    }
    public void playLevel4()
    {
        SceneManager.LoadScene(6);
    }
}
