using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerScript : MonoBehaviour
{
    //Rigidbody for the player.
    public Rigidbody2D rb;
    //Float variables for the player's Speed and Jump Force.
    public float speed = 15f;
    public float jumpforce = 15f;
    //Public Float variable for checking the radius of the circle
    public float checkRadius;
    //Transform that checks the ground to see if the player's on it.
    public Transform GroundChecker;
    //Public LayerMask that 
    public LayerMask GroundMask;
    //Private Float variable for the x axis.
    private float inputX;
    //Priate bool for checkin if the player is on the ground.
    private bool isOnGround;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //KeyCode for Space so the player can jump.
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {

            rb.velocity = new Vector2(rb.velocity.x, jumpforce);
        }
    }
}
