using System.Collections;
using UnityEngine;

public class Practice : MonoBehaviour
{
 void OnCollisionEnter(Collision other) 
 {
  switch (other.gameObject.tag)
  {
    case "friendly":
    Debug.Log("This is friendly");
    break;

    case "fuel":
    Debug.Log("You have picked up the fuel");
    break;

    case "finish":
    Debug.Log("Congratulations you have reached the finish point");
    break;

    default:
    Debug.Log("You blew up");
    break;
  }   
 }
}
