using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Klee_Movemont : MonoBehaviour
{
    public float speed;
    private Rigidbody klee_Rigidbody;
   
    private void Start()
    {
        klee_Rigidbody = GetComponent<Rigidbody>();

    }

    private void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        Vector3 Movemont = new Vector3 (xInput, 0, zInput).normalized;

        klee_Rigidbody.velocity = Movemont * speed * Time.deltaTime;

        transform.LookAt(transform.position + Movemont);

       

    }
}
