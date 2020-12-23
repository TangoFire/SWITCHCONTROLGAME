using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSwitch : MonoBehaviour
{
        
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            Debug.Log("hit");
           

            //destroy PlayerMovement and ControlSwitch from the previous target
            Destroy(GetComponent<PlayerMovement>());
            Destroy(GetComponent<ControlSwitch>());
            Destroy(GetComponent<Rigidbody2D>());
           
            Debug.Log("hit2");
            //On collision with an enemy, will add these components to an enemy
            collision.gameObject.AddComponent<PlayerMovement>();
            collision.gameObject.AddComponent<ControlSwitch>();
            collision.gameObject.AddComponent<Rigidbody2D>();

            //Name the object that is being hit the player and the old object an enemy
            //collision.gameObject.name = "Player";
            //gameObject.name = "Enemy";


        }
        
    }


}
