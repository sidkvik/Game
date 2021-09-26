using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class openLevelMenu : MonoBehaviour
{

    public GameObject button;

   public void startmenu()
    {
        GameDialogue.fromWitchLevel = 2f;
        SceneManager.LoadScene(2);
        PlayerMovement.endLevel2 = true;
    }
   
}
