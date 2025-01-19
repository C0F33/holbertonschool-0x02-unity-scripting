using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 5f;
    
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Get input from WASD/Arrow keys
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Create a movement vector
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            // Double the movement speed
            rb.linearVelocity = movement * Speed * 2;
        }
        else
        { 
            // Apply movement to the Rigidbody
            rb.linearVelocity = movement * Speed;
        }
    }
}
