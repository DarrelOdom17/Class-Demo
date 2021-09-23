using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multiply : MonoBehaviour
{
   public int value = 3;
  
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(MultiplyNumberByTwo(value));
    }

    int MultiplyNumberByTwo (int number)
    {
        int returnValue;
        returnValue = number * 2;
        return returnValue;
    }
}
