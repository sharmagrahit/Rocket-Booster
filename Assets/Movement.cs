using UnityEngine;

public class Movement : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }

    void ProcessThrust()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Pressed Space");
        }
    }
    void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Rotating Left");
        }
        if(Input.GetKey(KeyCode.D))
        {
            Debug.Log("Rotating Right");
        }
    }
}
