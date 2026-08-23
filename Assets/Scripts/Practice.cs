using System.Collections;
using UnityEngine;


public class Practice : MonoBehaviour
{
  float MainThrust = 1f;
  Rigidbody rb;

  void Start()
  {
    rb = GetComponent<Rigidbody>();
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
      rb.AddRelativeForce(Vector3.up * Time.deltaTime * MainThrust);
    }
  }

  void ProcessRotation()
  {
    if (Input.GetKey(KeyCode.A))
    {
      Debug.Log("Rotating Left");
    }
    else if (Input.GetKey(KeyCode.D))
    {
      Debug.Log("Rotating Right");
    }
  }
}

