using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody player;
    [SerializeField] private  float speed;
    private bool dMovement = true;
    private bool aMovement = true;


    void Start()
    {
        player = GetComponent<Rigidbody>();
        
    }
    
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }


    
        if(Input.GetKeyDown(KeyCode.A))
        {
            AMovement();
        }
      


        if (Input.GetKeyDown(KeyCode.D))
        {
            DMovement();
        }

     
        
    }


    private void DMovement()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (dMovement)
            {
                transform.Rotate(0, -270, 0);
            }

            dMovement = false;
          
            transform.Translate(Vector3.back * speed * Time.deltaTime);



        }
    }

    private void AMovement()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {

            if (aMovement)
            {
                transform.Rotate(0, 270, 0);
            }

            aMovement = false;

            transform.Translate(Vector3.back * speed * Time.deltaTime);

            


        }
    }

}
