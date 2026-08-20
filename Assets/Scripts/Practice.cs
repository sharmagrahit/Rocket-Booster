using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Practice : MonoBehaviour
{
  [SerializeField] GameObject cube;
  void OnCollisionEnter(Collision other)
  {
    switch (other.gameObject.tag)
    {
      case "friendly":
        Debug.Log("This is friendly");
        break;

      case "fuel":
        Debug.Log("You have picked up the fuel");
        cube.SetActive(false);
        break;

      case "finish":
        Debug.Log("Congratulations you have Finished Level One");
        break;

      default:
        Debug.Log("You blew up");
        break;

    }
  }
  void ReloadLevel()
  {
    int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    SceneManager.LoadScene(currentSceneIndex);
  }
}
