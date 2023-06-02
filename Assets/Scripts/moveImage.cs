using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveImage : MonoBehaviour
{
    // Start is called before the first frame update
    public RectTransform img;
    public float moveChar;
    public ArduinoConnector ard;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveChar = ard.inputValues.y;
        
        if(moveChar<130)   
        img.position = new Vector3(img.position.x - (((moveChar)) * Time.deltaTime) / 50f, img.position.y,img.position.z);
         
    }
}
