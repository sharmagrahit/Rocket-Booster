using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float mainThrust = 100f;
    [SerializeField] float RotationThrust = 100f;
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
            ApplyRotation(RotationThrust);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            ApplyRotation(-RotationThrust);
        }
    }

    void ApplyRotation(float rotationThisFrame)

    {
        transform.Rotate(Vector3.forward * Time.deltaTime * rotationThisFrame);
    }
}