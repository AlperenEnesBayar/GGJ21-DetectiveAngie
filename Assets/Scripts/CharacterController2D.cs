using UnityEngine;
using UnityEngine.Events;

public class CharacterController2D : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Animator animator;
    public Rigidbody2D rb;
    Vector2 movement;
    public GameObject Arrest;

    private void Start()
    {
        movement = new Vector2();
    }

    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if(movement.x == 0 && movement.y == 0)
        {
            animator.SetBool("isWalking", false);
        }
        else
        {
            animator.SetBool("isWalking", true);
        }

        if(movement.x < 0)
        {
            // Arrest.transform.eulerAngles = new Vector3(0, 180, 0); // Flipped
            Arrest.transform.eulerAngles = new Vector3(0, 0, 0); // Normal
            gameObject.transform.eulerAngles = new Vector3(0, 0, 0); // Normal
        }
        else if(movement.x == 0)
        {
            Arrest.transform.eulerAngles = new Vector3(0, 0, 0); // Normal
            gameObject.transform.eulerAngles = new Vector3(0, 0, 0); // Normal
        }
        else
        {
            Arrest.transform.eulerAngles = new Vector3(0, 0, 0); // Normal
            gameObject.transform.eulerAngles = new Vector3(0, 180, 0); // Flipped
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}