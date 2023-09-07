using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public GameObject Enemy;

    private bool startRoutine = true;

    private void Start()
    {
        startRoutine = true;
        
    }
    private void Update()
    {
        // start routine
        if (startRoutine == true)
        {
            StartCoroutine(waiter());
            startRoutine = false;
        }
        

        

        
    }
    IEnumerator waiter()
    {
        Instantiate(Enemy, new Vector3(0, 4, 0), Quaternion.identity);
        yield return new WaitForSeconds(10);
        startRoutine = true;
    }
}
