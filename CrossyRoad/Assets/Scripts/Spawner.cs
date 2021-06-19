using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField] GameObject spawnerObject;
    
    void Start()
    {
        
        StartCoroutine(SpawnRoutine());

    }


    void Update()
    {
        
      
    }
    

     IEnumerator SpawnRoutine()
    {

        

        while (true)
        {
            yield return new WaitForSeconds(2);
            GameObject obj = Instantiate(spawnerObject, SpawnEnemy(), spawnerObject.transform.rotation);
            Destroy(obj, 5);
            
        }
        


    }

    private Vector3 SpawnEnemy()
    {
        Vector3 pos = new Vector3(-15 ,1,2);
        return pos;
    }

    
    
  
}
