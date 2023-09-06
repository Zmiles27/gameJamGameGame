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

    private bool canShoot = true;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && canShoot)
        {
            shoot();
            StartCoroutine(fireTimer());
        }
    }
    void shoot()
    {
        canShoot = false;
        var bullet = Instantiate(bulletPrefab);
        bullet.transform.position = transform.position;
        bullet.transform.rotation = transform.rotation;
        
    }
    IEnumerator fireTimer()
    {
        yield return new WaitForSeconds(1 / firerate);
        canShoot = true;
    }
}
