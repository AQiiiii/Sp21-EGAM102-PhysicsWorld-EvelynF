﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class straightline : MonoBehaviour
{
    public GameObject ObjectToClone;

    public float XMin, XMax, XStep;

    public float YJitter;

    public float Slope, Intercept;


    void Start()
    {
        GameObject newObject;

        float x,
            y,
            z;
        z=0;

        for (x =XMin; x <XMax; x+=XStep)
        {

            newObject =Instantiate(ObjectToClone, this.transform);


            y = Slope * x - Intercept;

            newObject.transform. position = new Vector3(

            x,

            y+ Random.Range(-YJitter, YJitter), 

            z);

        }


    }
    
   
}
