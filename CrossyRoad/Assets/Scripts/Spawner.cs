using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField] GameObject spawnerObject;
    
    void Start()
    {
        InvokeRepeating(nameof(CallFunc), 1, 2);
    }

  
    void Update()
    {
        
    }

    private Vector3 SpawnEnemy()
    {
        Vector3 pos = new Vector3(-15 ,1,1);
        return pos;
    }

    private void CallFunc()
    {
       GameObject obj = Instantiate(spawnerObject, SpawnEnemy(), spawnerObject.transform.rotation);
        Destroy(obj, 5);
    }
}
