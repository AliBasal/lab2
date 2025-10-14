using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   public float moveSpeed; 
public float jumpHeight; 

public KeyCode Spacebar; 

public KeyCode L;
public KeyCode R;
    void Start()
    {
    }

void Update () {
    if(Input.GetKeyDown(Spacebar)) //When user presses the space button ONCE

Jump(); //see function definition below

if (Input.GetKey(L)) //When user presses the left arrow button


GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
//player character moves horizontally to the left along the x-axis without disrupting jump

if (Input.GetKey(R)) //When user presses the left arrow button

GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
//player character
}
void jump(){
GetComponent {Rigidbody2D}().velocity=new Vector2 (GetComponent<Rigidbody2D>().velocity.x,jumpHeight);
}
if (Input.GetKey(L)) //When user presses the left arrow button

GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
//player character moves horizontally to the left along the x-axis without disrupting jump

if(GetComponent<SpriteRenderer>() != null)
{
GetComponent<SpriteRenderer>().flipX = true;

}

if (Input.GetKey(R))
//When user presses the left arrow button

GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
//player character moves horizontally to the right along the x-axis without disrupting jump

if(GetComponent<SpriteRenderer>() != null)

GetComponent<SpriteRenderer>().flipX = false;

{

}
|

