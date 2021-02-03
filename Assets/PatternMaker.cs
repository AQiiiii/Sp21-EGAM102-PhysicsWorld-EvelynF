using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternMaker : MonoBehaviour
{
    public GameObject ObjectToClone;
    public float XMin, XMax, YMin, YMax;
    public int NClones;
    public float CloneScaleMin, CloneScaleMax;
    public bool RandomizeSpriteColors;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newObject;

        for(int starID = 0; starID < NClones; starID++)
        {
            newObject = Instantiate (ObjectToClone, this.transform);
            newObject.transform.position = new Vector3(
                Random.Range(XMin, XMax),
                Random.Range(YMin, YMax), 
                0);
            newObject.transform.localScale = Random.Range(CloneScaleMin, CloneScaleMax) * Vector3.one;


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
