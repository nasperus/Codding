using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forward : MonoBehaviour
{

  
    void Update()
    {
        transform.Translate(transform.right * 10 * Time.deltaTime);

        
    }
}
