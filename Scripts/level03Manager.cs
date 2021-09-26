using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level03Manager : MonoBehaviour

    
{


    public Transform spawner;
    public GameObject ball;

    public void spawnNew()
    {
        Instantiate(ball, spawner.position, spawner.rotation);
    }


  
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("b"))
        {
            Debug.Log("zmacknul jsi d");
            spawnNew();
           // OnCollisionEnter(collisionInfo);
        }
        


    }
   
}
