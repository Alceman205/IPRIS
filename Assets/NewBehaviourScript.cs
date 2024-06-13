using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class NewBehaviourScript : MonoBehaviour
{
    public Text xText;
    public Text yText;
    public Text zText;
    public AudioSource audioSource;

    public GameObject go;

    // Start is called before the first frame update
    void Start()
    {
       audioSource.Play();
       
    }

   public bool isInsideBounds(float goX, float goY, float xPos, float yPos,float width, float height) {

        return goX > xPos && goX <= xPos + width && goY > yPos && goY <= yPos + height;
    }

    // Update is called once per frame
    void Update()
    {
       Vector3 goPosition = go.transform.position; 

       


     float xPos = goPosition.x;
     float yPos = goPosition.y;


        xText.text = "X: " + xPos;
        yText.text = "Y: " + yPos;
        
        bool isBound = isInsideBounds(xPos, yPos, 0, 0, 1090, 533);

        zText.text = isBound ? "Ligado" : "Desligado";
     
        if(isBound)
            audioSource.UnPause();
        else
            audioSource.Pause();
        
        
        
    }
}
