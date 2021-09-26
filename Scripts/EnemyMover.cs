using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{

    public GameObject Player;
    public float speedWalking;
    public float speedRotation;


   
    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(Player.transform);
        Quaternion targetRotaion = Quaternion.LookRotation(Player.transform.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotaion, speedRotation * Time.deltaTime);
        transform.position += transform.forward * speedWalking * Time.deltaTime;
    
    
    
    }
    public void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Player")
        {
            Debug.Log("Byl jsi sneden"); 

        }

    }
}

