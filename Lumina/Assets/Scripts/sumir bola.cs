using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sumirbola : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("DANO"))
        {
            Destroy(other.gameObject);
        }
        if(other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
        }
    }
}
