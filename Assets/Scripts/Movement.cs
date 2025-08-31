using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Audio;
using UnityEngine.Rendering;

public class Movement : MonoBehaviour
{


    // MOVEMENT
    public float HorizontalDirection;
    public float speed;
    public Vector2 gravity;

    //THINGS
    private Rigidbody2D rigidBody2D;
    private CircleCollider2D boxCollider;
    public LayerMask groundLayer;

   
    //GROUND
    public Transform leftFoot;
    public Transform centerFoot;
    public Transform rightFoot;
    public float rayLength = 0.1f;

    



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        rigidBody2D = GetComponent<Rigidbody2D>();




    }

    // Update is called once per frame
    void Update()
    {
        //HORIZONTAL
        HorizontalDirection = Input.GetAxisRaw(axisName: "Horizontal");

        //HORIZONTAL ANIM

        //UHH
        rigidBody2D.linearVelocityX = HorizontalDirection * speed;

        





 

        //GRAVITY
        Physics2D.gravity = gravity;




    }
   

    
}




