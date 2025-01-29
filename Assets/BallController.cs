using UnityEngine;

public class BallController : MonoBehaviour
{
    

    [SerializeField] private Rigidbody sphereRigidbody;
    
    [SerializeField] private float ballspeed = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("calling the start method");
        
    }

    // Update is called once per frame
    public void MoveBall(Vector2 input)
    {



        Vector3 inputXZPlane =  new(input.x, 0, input.y);
        
        sphereRigidbody.AddForce(inputXZPlane * ballspeed);

        
    }
}
