using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyBall : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
      if(gameObject.transform.position.y < -30)
        {
            //gameObject.GetComponent<Rigidbody>().AddForce(0, 0, 0, ForceMode.VelocityChange);
            gameObject.transform.position = new Vector3(1.0f, 13f, 10f);
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;


        }
    }
}
