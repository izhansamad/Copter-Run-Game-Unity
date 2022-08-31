using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_obstacle : MonoBehaviour
{
    Rigidbody rb;
    public int speed = -8000;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Destroy"))
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Destroy"))
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(-5,0,0);
        rb.velocity = new Vector3(speed *Time.deltaTime, 0, 0);
        
    }
  
}
