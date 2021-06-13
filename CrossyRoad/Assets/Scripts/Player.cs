using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody player;
    [SerializeField] private  float speed;



    void Start()
    {
        player = GetComponent<Rigidbody>();
        
    }
    
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.rotation = Quaternion.LookRotation(Vector3.back);
            transform.Translate(Vector3.back * speed * Time.deltaTime);
            
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.rotation = Quaternion.LookRotation(Vector3.left);
            transform.Translate(Vector3.back * speed * Time.deltaTime);

        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.rotation = Quaternion.LookRotation(Vector3.right);
            transform.Translate(Vector3.back * speed * Time.deltaTime);



        }

    }


  
  

}
