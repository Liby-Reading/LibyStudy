using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour 
{

    private BoxCollider2D BoxCollider2D;
    private Vector3 moveDelta;

    private void start() {
        BoxCollider2D = GetComponent<BoxCollider2D>();
    }   

    private void FixedUpdate() {
    // line resets the moveDelta
    float x = Input.GetAxisRaw("Horizontal");
    float y = Input.GetAxisRaw("Vertical");

    // input for directin and movement
    moveDelta = new Vector3(x,y,0);

    // movements

    if(moveDelta.x > 0) {
        transform.localScale = Vector3.one;
    }
    else if(moveDelta.x < 0) {
        transform.localScale = new Vector3(-1,1,1 );
    }


    transform.Translate(moveDelta * Time.deltaTime);
    Debug.Log(x);
    Debug.Log(y);
    

    }
}
