using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public float gameHeight;
    public float gameWidth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float frustumHeight = 2.0f * Camera.main.transform.position.y 
                            * Mathf.Tan(Camera.main.fieldOfView * 0.5f * Mathf.Deg2Rad);
        gameHeight = frustumHeight;
        gameWidth = gameHeight * Camera.main.aspect;

        Debug.Log("Wysokoœæ pola gry:" + gameHeight + "szerokoœæ: " + gameWidth);


    }
}
