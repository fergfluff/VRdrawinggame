using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerHandler : MonoBehaviour {

    public Color paintColor;
    public GameObject paintBrush;
    public GameObject paint;

    public List<GameObject> usedPaint;

    void Start()
     {
        usedPaint = new List<GameObject>();
    }


    public void Draw()
    {
        //see which color is selected
        paintColor = paintBrush.GetComponent<MeshRenderer>().material.color;
        Debug.Log(paintColor);

        //add an instantiated paint prefab to the usedPaint list
        usedPaint.Add(Instantiate(paint));

        //store into a variable the last prefab in the list
        int last = usedPaint.Count - 1;

        //change the color and position of that last prefab
        usedPaint[last].GetComponent<MeshRenderer>().material.color = paintColor;
        usedPaint[last].transform.position = transform.position;

      }

    void Update()
        {
        //if there are more than 1000 paint prefabs
        if (usedPaint.Count > 1000)
             {
                Debug.Log(usedPaint);
                //Destroy the first paint prefab in the list
                Destroy(usedPaint[0]);
                usedPaint.RemoveAt(0);
            }
    }
}
