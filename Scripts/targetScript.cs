
using UnityEngine;




public class targetScript : MonoBehaviour
{

    public float health = 50f;
    public float level;
    public GameObject targetManager;
    

    

    public void TakeDamage (float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
        startAnotherLevelOfTargets();
    }
    void startAnotherLevelOfTargets()
    {
        if (level == 1f)
        {
            targetManager.GetComponent<Level02Manager>().startLevel2();
            GetComponent<DialogueTrigger2>().TriggerDialogue2();
        }
        if (level == 2f)
        {

            targetManager.GetComponent<Level02Manager>().startLevel3();
            GetComponent<DialogueTrigger2>().TriggerDialogue2();

        }
        if (level == 3f)
        {
            if (Level02Manager.logiclev3 == 3f)
            {
                GetComponent<DialogueTrigger2>().TriggerDialogue2();
                targetManager.GetComponent<Level02Manager>().finishTargets();
            }
            else
            {
                Level02Manager.logiclev3++;
                Debug.Log(Level02Manager.logiclev3);
            }
            
        }
    }



}
