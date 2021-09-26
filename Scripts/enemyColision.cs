using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyColision : MonoBehaviour
{
    public void OnCollisionEnter(UnityEngine.Collision kolize)
    {
        if (kolize.gameObject.tag == "Enemy")
        {
            Debug.Log("Byl jsi sneden");

        }

    }
}
