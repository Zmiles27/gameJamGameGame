using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpeed : MonoBehaviour
{
    public float speed;
    void Start()
    {
        StartCoroutine(timer());
    }

    void Update()
    {
        transform.position += new Vector3(0, -speed, 0) * Time.deltaTime;
    }

    IEnumerator timer()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}
