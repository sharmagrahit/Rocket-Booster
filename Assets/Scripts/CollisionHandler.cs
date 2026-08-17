using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "friendly":
                Debug.Log("This thing is friendly");
                break;
            case "Finish":
                Debug.Log("congratulations! you have reached finish point");
                break;
            case "fuel":
                Debug.Log("You picked up the fuel");
                break;
            default:
                Debug.Log("You Blew up");
                break;
        }
    }

}
