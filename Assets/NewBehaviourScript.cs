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

    // Start is called before the first frame update
    void Start()
    {
       audioSource.Play();
       
    }

   public bool isInsideBounds(float mouseX, float mouseY, float xPos, float yPos,float width, float height) {

        return mouseX > xPos && mouseX <= xPos + width && mouseY > yPos && mouseY <= yPos + height;
    }

    // Update is called once per frame
    void Update()
    {
       Vector3 mousePosition = Input.mousePosition; 

       


     float xPos = mousePosition.x;
     float yPos = mousePosition.y;


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
