using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandlerMoveFR : MonoBehaviour
{

    public GameObject pistol;
    public GameObject textKPosuvniku1;



    public void SetVolume(float ammount)
    {

        textKPosuvniku1.GetComponent<Text>().text = ammount.ToString("0");
        GameObject.Find("Pistol").GetComponent<GunScript>().fireRate = ammount;
    }
}
