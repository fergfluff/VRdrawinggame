using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSelector : MonoBehaviour {

    public Color cubeColor;
    public GameObject paintBrush;

    
    private void OnTriggerEnter(Collider other)
    {
        //Get the color of the cube
        cubeColor = GetComponent<MeshRenderer>().material.color;
        //set the sphere's color to the cube color
        paintBrush.GetComponent<MeshRenderer>().material.color = cubeColor;
        //Debug.Log("sphere color is " + sphere.GetComponent<MeshRenderer>().material.color);

    }

}
