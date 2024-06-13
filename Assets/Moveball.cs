using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveball : MonoBehaviour
{
    private float delta = 0f;
    private float limit = 15f;

    private float speed = 10f;
    private float velocity = 0.1f;

    private float gravity = -50.0f;
  
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity = new Vector3(0, gravity, 0);
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        if ((h != 0) || (v != 0))
        {
            if (delta < limit)
                delta += velocity;
        } 
        else
            delta = 0f;


        h = h * speed * delta;
        v = v * speed * delta;

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

