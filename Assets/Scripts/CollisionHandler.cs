using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] GameObject cube;
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
                cube.SetActive(false);
                break;
            default:
                Debug.Log("You Blew up");
                ReloadScene();
                break;
        }
    }
    void ReloadScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
