using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ZombieController : MonoBehaviour
{
    public float Speed = 1f;
    public float turnSpeed = 90f;
    public GameObject zombie;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Turn", 1,1);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * Speed);      
    }
    public void Turn()
    {
        //Make the zombie turn

        transform.Rotate(Vector3.up, turnSpeed);
    }
}
