using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector2 speed = new Vector2(2,2);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // velocidade
        /*v = delta s / delta t
        delta s = v * delta t*/
           // transform.position += new Vector3(velocidade * Time.deltaTime,0.0f,0.0f);
           float inputX = Input.GetAxis("Horizontal");
           float inputY = Input.GetAxis("Vertical");

           Vector3 movement = new Vector3(speed.x * inputX, speed.y * inputY, 0);
           movement *= Time.deltaTime;

           transform.Translate(movement);
        }
        
       
    
}
