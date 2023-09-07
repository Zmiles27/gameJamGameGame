using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingEnemy : MonoBehaviour
{
    [SerializeField] private GameObject enemyBulletPrefab;
    public int ShootDelay;
    void Start()
    {
        StartCoroutine(fireTimer());
    }

    void shoot()
    {
        enemyBulletPrefab.transform.position = transform.position;
        StartCoroutine(fireTimer());
    }
    IEnumerator fireTimer()
    {
        Instantiate(enemyBulletPrefab);
        yield return new WaitForSeconds(ShootDelay);
        shoot();

    }
}
