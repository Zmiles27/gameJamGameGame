using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDead : MonoBehaviour
{
    [SerializeField] private GameObject rateDrop;
    [SerializeField] private GameObject sizeDrop;
    [SerializeField] private GameObject speedDrop;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            if (Random.Range(1,2) == 1)
            {
                var type = Random.Range(1, 4);
                if(type == 1)
                {
                    var i = Instantiate(speedDrop);
                    i.transform.position = transform.position;
                }
                if (type == 2)
                {
                    var i = Instantiate(sizeDrop);
                    i.transform.position = transform.position;
                }
                if (type == 3)
                {
                    var i = Instantiate(rateDrop);
                    i.transform.position = transform.position;
                }
            }
        }
    }
}
