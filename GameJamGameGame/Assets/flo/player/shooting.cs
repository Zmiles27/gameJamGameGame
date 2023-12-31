using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    public float firerate;
    public float speed;
    public Vector3 size;
    public int bulletAmount;
    public int bulletPierce;

    public int speedUp;
    public int rateUp;
    public int sizeUp;
    

    private bool canShoot = true;
    void Start()
    {
        
    }

    void Update()
    {
        firerate = (float)(rateUp + 1.50);
        speed = (float)(speedUp * 10 + 10);
        size = new Vector3(0.2f, 0.6f, 1f) * ((float)sizeUp + 1) ;
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
        bulletScript.size = size;
        bullet.transform.position = transform.position;
        
    }
    IEnumerator fireTimer()
    {
        yield return new WaitForSeconds(1/firerate);
        canShoot = true;
    }
}
