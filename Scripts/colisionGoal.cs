using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionGoal : MonoBehaviour
{
    public void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Ball")
        {
            Debug.Log("gol");
            gameObject.GetComponent<DialogueTrigger2>().TriggerDialogue2();

        }

    }
}
