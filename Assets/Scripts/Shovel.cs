using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Shovel : MonoBehaviour
{
    public GameObject zombie;

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            zombie = GameObject.FindGameObjectWithTag("Zombie");
            Destroy(zombie);
        }
    }
}
