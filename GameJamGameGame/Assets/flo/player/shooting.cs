using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    public float firerate;
    public float speed;
    public float size;
    public int bulletAmount;
    public int bulletPierce;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            shoot();
            StartCoroutine(fireTimer());
        }
    }
    void shoot()
    {
        var bullet = Instantiate(bulletPrefab);
        bullet.transform.position = transform.position;
        bullet.transform.rotation = transform.rotation;
        
    }
    IEnumerator fireTimer()
    {
        yield return new WaitForSeconds(1 / firerate);
    }
}
