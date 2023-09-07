using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{

    public float speed;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += new Vector3(0, speed, 0) * Time.deltaTime;
    }
}
