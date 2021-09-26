using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{


    public CharacterController controller;
    public float speed = 12f;
    public float jumpHeight = 3f;
    
    
    
    public float gravity = -15.81f;
    public Transform groundCheck;
    public Transform cilinderCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMAsk;
    public Animator animatorCubeZMinus;
    public Animator animatorCubeZPlus;
    public Animator animatorCubeZMinus1;
    public Animator animatorFinish;
    public float dialogueNumber;
    static public bool endLevel = false;
    static public bool endLevel2 = false;
    static public bool endLevel3 = false;
    static public bool endLevel4 = false;
    static public bool endGame = false;

    public Vector3 velocity;
    bool isGrounded;

    // Update is called once per frame
    void Update()
    {
      







        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMAsk);
        if (isGrounded && velocity.y <0)
            {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");


        //Info 1
               
        if (Physics.CheckSphere(cilinderCheck.position, 2, LayerMask.GetMask("info")) == true)
        {
            animatorCubeZMinus.SetBool("IsClose", true);
        }

        //Info 2

        if (Physics.CheckSphere(cilinderCheck.position, 2, LayerMask.GetMask("Info2")) == true)
        {
            Debug.Log("Jsi blizko");
            animatorCubeZPlus.SetBool("fadeInfo2", true);

        }
        //IFinish

        if (Physics.CheckSphere(cilinderCheck.position, 2, LayerMask.GetMask("Finish")) == true)
        {

            Debug.Log("Jsi blizko");

            if (GameDialogue.fromWitchLevel == 1)
            {
                endLevel = true;
            } 
            if(GameDialogue.fromWitchLevel == 2)
            {
                endLevel2 = true;
                Debug.Log(GameDialogue.fromWitchLevel = 2);
                Debug.Log(endLevel2);
            } 
            if(GameDialogue.fromWitchLevel == 3)
            {
                endLevel3 = true;
            }
            if(GameDialogue.fromWitchLevel == 4)
            {
                endLevel4 = true;
            }
            animatorFinish.SetBool("FadeFinish", true);
        }


        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);


        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);

        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
        
    }
}
