using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody player;
    public float mspeed,rotatespeed;
    void FixedUpdate(){
        if(Input.GetKey(KeyCode.W)){
            player.velocity = transform.forward*mspeed*Time.deltaTime;
        }if(Input.GetKey(KeyCode.S)) { 
            player.velocity = -transform.forward *mspeed*Time.deltaTime;
        }
    }
    void Update(){
        if(Input.GetKey(KeyCode.D)){
            transform.Rotate(0,rotatespeed*Time.deltaTime,0);
        }else if (Input.GetKey(KeyCode.A)) {
            transform.Rotate(0,-rotatespeed*Time.deltaTime,0);
        }   
        }
    
}
