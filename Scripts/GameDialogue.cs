using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameDialogue : MonoBehaviour
{

    public Text nameText;
    public Text dialogueText;
    public InputField inputField;
    bool shootingIsAllowed1;

    public Animator animator;
    static public float fromWitchLevel;
    static public bool[] finishedLevels = new bool[4];

    float ukazInput = 1f;

    private Queue<string> sentences2;

    
    void Start()
    {
        sentences2 =new Queue<string>();
    }
    public void StartDialogue(Dialogue_class dialogue2)
    {
        Cursor.lockState = CursorLockMode.None;
        GunScript.shootingIsAllowed = false;

        
        animator.SetBool("IsOpen", true);


        nameText.text = dialogue2.name1;


       sentences2.Clear();
        foreach (string sentence1 in dialogue2.sentences2)
        {
            sentences2.Enqueue(sentence1);
        }
        if (PlayerMovement.endLevel == true ||  PlayerMovement.endLevel2 == true || PlayerMovement.endLevel3 == true || PlayerMovement.endLevel4 == true)
        {
            sentences2.Enqueue(DialogueManager.jmenoHrace + ", " + dialogue2.lastSentence);

        }
        

        DisplayNextSentence();

    }
    public void DisplayNextSentence()
    {
       
        if (sentences2.Count ==0f)
        {
            EndDialogue();
            return;
        }
        string sentance1 = sentences2.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentance1));
       
        ukazInput++;



    }

    IEnumerator TypeSentence(string sentence1)
    {
        dialogueText.text = "";
        foreach (char letter in sentence1.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

  
    void EndDialogue()
    {
     
        animator.SetBool("IsOpen", false);
        Cursor.lockState = CursorLockMode.Locked;
        GunScript.shootingIsAllowed = true;

        if (PlayerMovement.endLevel == true)
        {
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene(2);
            finishedLevels[0] = true;
           
            cancelFinishLevel();

        }
        if (PlayerMovement.endLevel2 == true)
        {
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene(2);
            finishedLevels[1] = true;

            cancelFinishLevel();

        }
        if (PlayerMovement.endLevel3 == true)
        {
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene(2);
            finishedLevels[2] = true;

            cancelFinishLevel();

        }
        if (PlayerMovement.endLevel4 == true)
        {
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene(2);
            finishedLevels[3] = true;

            cancelFinishLevel();

        }

    }
    void cancelFinishLevel()
    {
        PlayerMovement.endLevel = false;
        PlayerMovement.endLevel2 = false;
        PlayerMovement.endLevel3 = false;
        PlayerMovement.endLevel4 = false;
    }
}
