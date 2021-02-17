using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selfdest : MonoBehaviour
{
    public float Lifespan;

    private float TimeOfDeath;

    // Start is called before the first frame update
    void Start()
    {
        TimeOfDeath = Time.time + Lifespan;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > TimeOfDeath)
        {
            Destroy(this.gameObject);
        }
    }
}
