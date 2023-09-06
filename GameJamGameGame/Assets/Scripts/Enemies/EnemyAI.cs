using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public GameObject enemy;

    public int speed;
    public int minSpeed;
    public int maxSpeed;
    private int rngDircetion;
    public int direction;

    private bool startRoutine = true;

    private void Start()
    {
        startRoutine = true;
        enemy.transform.position = new Vector3(0, 4, 0);
    }
    private void Update()
    {
        // start routine
        if (startRoutine == true)
        {
            StartCoroutine(waiter());
            startRoutine = false;
        }

        //Chooses direction
        if (rngDircetion == 1)
        {
            direction = -1;
        }
        else if (rngDircetion == 2)
        {
            direction = 1;
        }
        
        // Moving
        enemy.transform.position += new Vector3 (direction,0,0)  * speed * Time.deltaTime;

        // tp
        if (enemy.transform.position.x > 9)
        {
            enemy.transform.position = new Vector3(-9, 4, 0);
        }
        if (enemy.transform.position.x < -9)
        {
            enemy.transform.position = new Vector3(9, 4, 0);
        }
    }
    IEnumerator waiter()
    {
        speed = Random.Range(minSpeed, maxSpeed);
        rngDircetion = Random.Range(1, 3);
        yield return new WaitForSeconds(3);
        startRoutine = true;
    }
}
