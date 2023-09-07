using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemaneger : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    void Start()
    {
        StartCoroutine(spawnTimer());
    }

    void Update()
    {
        
    }
    void spawn()
    {
        var Enemy = Instantiate(enemy);
        Enemy.transform.position = new Vector3(0, 4, 0);
        StartCoroutine(spawnTimer());
    }
    IEnumerator spawnTimer()
    {
        yield return new WaitForSeconds(Random.Range(2,5));
        spawn();
    }
}
