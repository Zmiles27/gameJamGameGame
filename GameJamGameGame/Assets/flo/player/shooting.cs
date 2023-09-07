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

    [SerializeField] private int speedUp;
    [SerializeField] private int rateUp;
    [SerializeField] private int sizeUp;
    

    private bool canShoot = true;
    void Start()
    {
        
    }

    void Update()
    {
        firerate = (float)(rateUp / 2 + 1.50);
        speed = (float)(speedUp * 5 + 10);
        size = (float)(sizeUp / 4 + 1);
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
        var bulletScript = bullet.GetComponent<bulletScript>();
        bulletScript.speed = speed;
        bullet.transform.position = transform.position;
        bullet.transform.rotation = transform.rotation;
        
    }
    IEnumerator fireTimer()
    {
        yield return new WaitForSeconds(1 / firerate);
        canShoot = true;
    }
}
