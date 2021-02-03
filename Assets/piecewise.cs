using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piecewise : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ObjectToClone;
    public float StepSize;
   
    // Start is called before the first frame update
    void Start()
    {
        GameObject newObject;
        for (int stepNumber = 0; stepNumber < 5; stepNumber ++)
        {
            newObject = Instantiate(ObjectToClone);
            newObject.transform.position = transform.position;

            this.transform.position += transform.TransformVector(Vector3.right);
        }

        this.transform.localEulerAngles += new Vector3 (0,0,150);

        for (int stepNumber = 0; stepNumber < 5; stepNumber ++)
        {
            newObject = Instantiate(ObjectToClone);
            newObject.transform.position = transform.position;

            this.transform.position += transform.TransformVector(Vector3.right);
        }

        this.transform.localEulerAngles += new Vector3 (0,0,-150);

        for (int stepNumber = 0; stepNumber < 5; stepNumber ++)
        {
            newObject = Instantiate(ObjectToClone);
            newObject.transform.position = transform.position;

            this.transform.position += transform.TransformVector(Vector3.right);
        }

        

        

    }
}
