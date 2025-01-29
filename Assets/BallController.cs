using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody sphereRigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("calling the start method");
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector2 inputvector = Vector2.zero;
        if (Input.GetKey(KeyCode.W)){
            inputvector += Vector2.up;
        }

        if(Input.GetKey(KeyCode.A)){
            inputvector += Vector2.left;
        }
        if(Input.GetKey(KeyCode.S)){
            inputvector += Vector2.down;
        }
        if(Input.GetKey(KeyCode.D)){
            inputvector += Vector2.right;
        }
    
        

        Vector3 inputXZPlane =  new(inputvector.x, 0, inputvector.y);
        
        sphereRigidbody.AddForce(inputXZPlane);

        
    }
}
