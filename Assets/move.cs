using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    public float MovementStrength, JumpStrength;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody2D thisRigidbody;

            thisRigidbody = GetComponent<Rigidbody2D>();

            thisRigidbody.AddForce(JumpStrength * Vector3.up, ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Rigidbody2D thisRigidbody;

            thisRigidbody = GetComponent<Rigidbody2D>();

            thisRigidbody.gravityScale *= -1;
        }


    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Rigidbody2D thisRigidbody;

            thisRigidbody = GetComponent<Rigidbody2D>();

            thisRigidbody.AddForce(MovementStrength * Vector3.right, ForceMode2D.Force);

            GameObject Eyeball = GameObject.Find("Eyebal1");
            Eyeball.transform.localScale = new Vector3(1, 1, 1);
        }


        if (Input.GetKey(KeyCode.A))
        {
            Rigidbody2D thisRigidbody;

            thisRigidbody = GetComponent<Rigidbody2D>();

            thisRigidbody.AddForce(MovementStrength * Vector3.left, ForceMode2D.Force);

            GameObject Eyeball = GameObject.Find("Eyeball");

            Eyeball.transform.localScale = new Vector3(-1, 1, 1);
        }


    }

}
