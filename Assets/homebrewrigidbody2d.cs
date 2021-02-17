using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homebrewrigidbody2d : MonoBehaviour
{
    public Vector3 Velocity, Acceleration,TotalForce,Gravity;

    public Vector3 gravity;

    public float Mass;

    private void FixedUpdate()
    {
        TotalForce += gravity;
        transform.position += Velocity * Time.fixedDeltaTime;
        Velocity += Acceleration * Time.fixedDeltaTime;
        Acceleration = TotalForce / Mass;
        TotalForce = Vector3.zero;
    }


        
    
}
