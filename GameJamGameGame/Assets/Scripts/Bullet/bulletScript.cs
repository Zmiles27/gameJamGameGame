using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{

    public float speed;
    void Start()
    {
        StartCoroutine(timer());
    }

    void Update()
    {
        transform.position += new Vector3(0, speed, 0) * Time.deltaTime;
    }
    
    IEnumerator timer()
    {
        yield return new WaitForSeconds(20);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D colider)
    {
        if (colider.gameObject.tag == "Enemy")
        {
            Destroy(colider.gameObject);
            Destroy(gameObject);
        }
    }
}

