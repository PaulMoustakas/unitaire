using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlls : MonoBehaviour
{


    static Animator anim;
    public float speed = 0; 
    public float rotationSpeed = 100.0f;



    private float timeRemaining = 3;
    private bool isBowDrawn;
   





    void Start()
    {
        anim = GetComponent<Animator>();
        isBowDrawn = false; 
        
    }

  
    void Update()
    {

        float translation = Input.GetAxis("Vertical") * speed;
       // print(translation);
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);




        if (Input.GetMouseButton(0))
        {
            speed = 0.5f;
            anim.SetBool("isAiming", true);
            print(timeRemaining);

            if (isBowDrawn == true)
            {
                if (timeRemaining > 3)
                {
                    timeRemaining -= Time.deltaTime;
                }


                else
                {
                    print("shooooooting");
                    timeRemaining = 0;
                    isBowDrawn = false; 
                }

             

            }
        }


        if (Input.GetMouseButtonUp(0))
        {
          //  print("release");
            //anim.SetBool("isAiming", false);
            // anim.SetBool("isAiming", false);
            print("Shooting"); 
        }

        if (! Input.GetMouseButton(0))
        {
                anim.SetBool("isAiming", false);

        }
        



            if (Input.GetKey(KeyCode.W))
        {

            speed = 4; 
            anim.SetTrigger("isRunning");
            anim.SetBool("isIdle", false);  // WHne attacking, take em out from the current state.
         
        }

        if (translation != 0)
        {
            anim.SetBool("isRunning", true); 
        }
        else
        {
            anim.SetBool("isRunning", false); 
        }
    }








        public void shootArrow(int power)
        {
            // pew pew 
        }

}
