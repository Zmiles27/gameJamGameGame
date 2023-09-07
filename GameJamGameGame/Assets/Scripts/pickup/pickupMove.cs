using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupMove : MonoBehaviour
{ 
    
    void Update()
    {
        if(transform.position.y > -4)
        {
            transform.position -= new Vector3(0, 4, 0) * Time.deltaTime;
        }
    }
}
