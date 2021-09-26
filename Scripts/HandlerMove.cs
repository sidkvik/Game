using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandlerMove : MonoBehaviour
{

    public string nazevPosuvniku;
    public GameObject textKPosuvniku1;
    public GameObject pistol;



    public void SetVolume(float ammount)
    {

        textKPosuvniku1.GetComponent<Text>().text = ammount.ToString("0");


        //Gun Settings

        if(nazevPosuvniku == "FR")
        {
            pistol.GetComponent<GunScript>().fireRate = ammount;
        }
        if (nazevPosuvniku == "IF")
        {
            pistol.GetComponent<GunScript>().impactForce = ammount;
        }
        if (nazevPosuvniku == "Damage")
        {
            pistol.GetComponent<GunScript>().damage = ammount;
        }
        if (nazevPosuvniku == "Range")
        {
            pistol.GetComponent<GunScript>().range = ammount;


            //Move Settings
        }
        if (nazevPosuvniku == "Speed")
        {
            pistol.GetComponent<PlayerMovement>().speed = ammount;
        }
        if (nazevPosuvniku == "Jump")
        {
            pistol.GetComponent<PlayerMovement>().jumpHeight = ammount;
        }
        if (nazevPosuvniku == "Gravity")
        {
            pistol.GetComponent<PlayerMovement>().gravity = -ammount;
        }
        if (nazevPosuvniku == "Sen")
        {
            pistol.GetComponent<mouseLook>().mouseSensitivity = ammount;
        }



    }
}
