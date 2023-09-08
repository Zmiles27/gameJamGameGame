using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    [SerializeField] private shooting set;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("pickup" + collision.tag);
        if(collision.tag == "rate")
        {
            Destroy(collision.gameObject);
            set.rateUp++;
        }
        else if (collision.tag == "size")
        {
            Destroy(collision.gameObject);
            set.sizeUp++;
        }
        else if (collision.tag == "speed")
        {
            Destroy(collision.gameObject);
            set.speedUp++;
        }
    }
}
