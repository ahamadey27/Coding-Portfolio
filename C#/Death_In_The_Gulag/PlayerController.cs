using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D theRB;
    public float moveSpeed;
    public Animator myAnim;
    public static PlayerController instance;
    public string areaTransitionName;
    public bool canMove = true;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        if (!canMove)
        {
            StopPlayerMovement();
            return;
        }

        HandleMovement();
    }

    private void HandleMovement()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        Vector2 moveVelocity = moveInput.normalized * moveSpeed;

        theRB.velocity = moveVelocity;

        // Update Animation
        myAnim.SetFloat("moveX", moveVelocity.x);
        myAnim.SetFloat("moveY", moveVelocity.y);

        bool isMoving = moveInput != Vector2.zero;
        myAnim.SetBool("IsMoving", isMoving);

        if (isMoving)
        {
            myAnim.SetFloat("lastMoveX", moveInput.x);
            myAnim.SetFloat("lastMoveY", moveInput.y);
        }
    }

    private void StopPlayerMovement()
    {
        theRB.velocity = Vector2.zero;

        // Reset animation parameters
        myAnim.SetFloat("moveX", 0);
        myAnim.SetFloat("moveY", 0);
        myAnim.SetBool("IsMoving", false);
    }
}
