using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frictionn : MonoBehaviour
{
    public float Drag;

    public string NameOfDragger;

    private Rigidbody2D thisRigidbody2D;


    // Start is called before the first frame update
    void Start()
    {
        thisRigidbody2D = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    private void OnTriggerStay2D (Collider2D collision)
    {
        if (collision. gameObject. name == NameOfDragger)
        {
            Vector3 velocityOfDragger = collision. gameObject.GetComponent<Rigidbody2D>(). velocity;
            thisRigidbody2D.AddForce (Drag * velocityOfDragger);
        }

    }


}
