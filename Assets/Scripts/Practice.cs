using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Practice : MonoBehaviour
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
    if (Input.GetKey(KeyCode.Space))
    {
      Debug.Log("You have pressed Space");
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

