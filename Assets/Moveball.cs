using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveball : MonoBehaviour
{  
  
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal") * 5;
        float v = Input.GetAxis("Vertical") * 5;

        Vector3 vel = rb.velocity;
        vel.x = h;
        vel.z = v;
        rb.velocity = vel;


        Vector3 objectPosition = rb.position; 

      

     float xPos = objectPosition.x;
     float yPos = objectPosition.y;

     Debug.Log("x: " + xPos);
        
    }

    public bool isInsideBounds(float mouseX, float mouseY, float xPos, float yPos,float width, float height) {

        return mouseX > xPos && mouseX <= xPos + width && mouseY > yPos && mouseY <= yPos + height;
    }
}

