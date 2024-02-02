using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    private Vector3 directionVector;
    private Transform myTransform;
    public float speed;
    private Rigidbody2D myRigidbody;
    private Animator anim;

    // Variables to store the last movement direction
    private float lastMoveX, lastMoveY;

    // Collision detection variables
    private bool isColliding = false;
    private float collisionDuration = 0f;
    public float maxCollisionDuration = 2f;  // Adjust this in the editor for how long the NPC should wait before changing direction when stuck

    void Start()
    {
        anim = GetComponent<Animator>();
        myTransform = GetComponent<Transform>();
        myRigidbody = GetComponent<Rigidbody2D>();

        ChangeDirection();
        InvokeRepeating("ChangeDirection", 1f, 4f);
    }

    void Update()
    {
        if (!DialogManager.isDialogueActive)
        {
            Move();
            UpdateAnimation();
        }
        else
        {
            anim.SetFloat("moveX", 0);
            anim.SetFloat("moveY", 0);
        }
    }

    private void Move()
    {
        Vector3 prevPosition = myTransform.position;
        myRigidbody.MovePosition(myTransform.position + directionVector * speed * Time.deltaTime);

        if (prevPosition == myTransform.position)
        {
            if (isColliding)
            {
                collisionDuration += Time.deltaTime;
                if (collisionDuration >= maxCollisionDuration)
                {
                    ChangeDirection();
                    collisionDuration = 0;
                }
            }
            else
            {
                isColliding = true;
                collisionDuration = 0;
            }
        }
        else
        {
            isColliding = false;
            collisionDuration = 0;
        }
    }

    void ChangeDirection()
    {
        int direction = Random.Range(0, 4);
        switch (direction)
        {
            case 0:
                directionVector = Vector3.right;
                break;
            case 1:
                directionVector = Vector3.up;
                break;
            case 2:
                directionVector = Vector3.left;
                break;
            case 3:
                directionVector = Vector3.down;
                break;
            default:
                break;
        }
    }

    void UpdateAnimation()
    {
        if (directionVector != Vector3.zero)
        {
            anim.SetFloat("moveX", directionVector.x);
            anim.SetFloat("moveY", directionVector.y);

            // Update the lastMoveX and lastMoveY whenever there is movement
            lastMoveX = directionVector.x;
            lastMoveY = directionVector.y;
        }
        else
        {
            anim.SetFloat("moveX", 0);
            anim.SetFloat("moveY", 0);
        }

        // Set the last movement direction for the idle animations
        anim.SetFloat("lastMoveX", lastMoveX);
        anim.SetFloat("lastMoveY", lastMoveY);
    }
}
