using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangerCube : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        // Changes the color of the selected component to red, 
        // blue or yellow depending on the number pressed.

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }
    }
}
