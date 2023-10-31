using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coffin : MonoBehaviour
{
    public GameObject objectToSpawn;
    public GameObject coffin;

   

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Instantiate(objectToSpawn, transform.position, objectToSpawn.transform.rotation);
            Destroy(coffin);
        }
    }

}
