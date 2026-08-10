using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float mainThrust = 100f;
    Rigidbody rd;
    void Start()
    {
        rd = GetComponent<Rigidbody>();
    }
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }
    void ProcessThrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rd.AddRelativeForce(Vector3.up * Time.deltaTime * mainThrust);
        }
    }
    void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward);
            //or we can use transform.Rotate(0, 0, 1);      
        }

        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward);
            //or we can use transform.Rotate(0, 0, -1);
        }
    }
}