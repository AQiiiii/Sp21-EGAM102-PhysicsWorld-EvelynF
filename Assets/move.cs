using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
   
    public float MoveStren, JumpStre;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody2D thisRigidbody;
            thisRigidbody = GetComponent<Rigidbody2D>();
            thisRigidbody.AddForce(JumpStre * Vector3.up, ForceMode2D.Impulse);

        }

    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Rigidbody2D thisRigidbody;
            thisRigidbody = GetComponent<Rigidbody2D>();
            thisRigidbody.AddForce(MoveStren * Vector3.right, ForceMode2D.Force);

        }
        if (Input.GetKey(KeyCode.A))
        {
            Rigidbody2D thisRigidbody;
            thisRigidbody = GetComponent<Rigidbody2D>();
            thisRigidbody.AddForce(MoveStren* Vector3.left, ForceMode2D.Force);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "a53")
        {
            sound.instance.A53();
   
        }
        
        if (collision.gameObject.tag == "a54")
        {
            sound.instance.A54();
        }
        if (collision.gameObject.tag == "a55")
        {
            sound.instance.A55();
        }
        if (collision.gameObject.tag == "a56")
        {
            sound.instance.A56();
        }
        if (collision.gameObject.tag == "a57")
        {
            sound.instance.A57();
        }
        if (collision.gameObject.tag == "a61")
        {
            sound.instance.A61();
        }

    }

   



}
