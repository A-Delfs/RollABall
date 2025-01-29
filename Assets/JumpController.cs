using UnityEngine;

public class JumpController : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField] private float jumpForce = 5f;
    
    private bool isGrounded;

    void Start()
    {
        isGrounded = true; 
    }

    public void Jump()
    {
        if (isGrounded)
        {
            sphereRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false; 
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
