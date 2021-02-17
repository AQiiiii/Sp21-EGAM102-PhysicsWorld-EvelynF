using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket : MonoBehaviour
{
    public Vector3 RocketForce;
    public float RocketDuration;
    public float ExplosionDelay;
    public int ExplosionPieces;
    public float ExplosionForce;
    public GameObject ExplosionPiecePrefab; // the object whhich will explosed 
    private float RocketCutofTime;
    private float ExplosiononTime;

    // Start is called before the first frame update
    void Start()
    {
        RocketCutofTime = Time.time + RocketDuration; // calculate the time rocket have upward force.
        ExplosiononTime = Time.time + ExplosionDelay; // calculate the explosiontime.
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if(Time.time < RocketCutofTime)// if the time is less that the cut off time the rocket will keep moving upward.
        {
            GetComponent<homebrewrigidbody2d>().TotalForce += RocketForce;// push the rocket

        }
        if(Time.time > ExplosiononTime) // if the time is over the explosion time it will explode.
        {
            GameObject newExplosionPiece; 
            for (int i = 0; i< ExplosionPieces;i++) //generate pieces until a certain number is meet. 
            {
                newExplosionPiece = Instantiate(ExplosionPiecePrefab); // reference the explosed object
                newExplosionPiece.transform.position = this.transform.position; // set the position
                newExplosionPiece.GetComponent<homebrewrigidbody2d> ().Velocity = this.GetComponent<homebrewrigidbody2d>().Velocity;// set the explosion obbject to have the same speed with the rocket.
                newExplosionPiece.GetComponent<homebrewrigidbody2d>().TotalForce = ExplosionForce* Random.insideUnitCircle; // add force to push the pieces to different directions.
            }
            Destroy(this.gameObject);// destory the pieces when the time comes.
        }
    }
}
