using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopNumberer : MonoBehaviour
{
    void Start()
    {
        //Prints the odds from 1 to 99, all with one Debug.Log: 1, 3, 5, .... 99
        string outputString = "";
        
        outputString = "";
        for (int i=0; i < 50; i++)
        {
            int nextNumberToPrint = 2 * i + 1;
            outputString += nextNumberToPrint.ToString() + ",";
        }
        Debug.Log(outputString);

        //Prints the fives from 55 to 255, all with one Debug.Log: 55, 60, 65, 70, ... , 255
       outputString = "";
        for (int i=1; i < 42; i++)
        {
            int nextNumberToPrint = i * 5 + 50;
            outputString += nextNumberToPrint.ToString()+",";
        }
        Debug.Log(outputString);

        //Prints the evens from -100 to 0, all with one Debug.Log: -100, -98, -96, ... -2, 0
        outputString = "";
        for (int i=1; i < 52; i++)
        {
            int nextNumberToPrint = i * 2 - 102 ;
            outputString += nextNumberToPrint.ToString()+",";
        }
        Debug.Log(outputString);

        //(+8) Print the 10’s from 10 to 100, alternating +/-: 0, -10, 20, -30, 40, -50, etc.
        outputString = "";
        for (int i=0; i < 11; i++)
        {
            
            if (i%2 == 0)
            {
                int nextNumberToPrint = i * 10;
                outputString += nextNumberToPrint.ToString()+",";
            }
            else
            {
                int nextNumberToPrint = i * -10;
                outputString += nextNumberToPrint.ToString()+",";
            }
            
        }
        Debug.Log(outputString);

        //Print every number between 0 and 1000 that is divisible by either 6 or 13: 
        outputString = "";
        for (int i=0; i < 100; i++)
        {
            int nextNumberToPrint = i + 1;
            if(nextNumberToPrint % 6 == 0 || nextNumberToPrint % 13 == 0)
            {
                outputString += nextNumberToPrint.ToString() + ",";
            }
           
        }
        Debug.Log(outputString);

        //Prints the prime numbers from 0 to 500: 1, 3, 5, 7, 13, 17, ... 
        
      
    }


}
