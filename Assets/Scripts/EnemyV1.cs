using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyV1 : MonoBehaviour
{
    public bool isAlive = true;


    void Start()
    {
        
    }

    
    void Update()
    {



    }

    public void OnMouseDown()
    {
        isAlive = false;
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

    }


}

