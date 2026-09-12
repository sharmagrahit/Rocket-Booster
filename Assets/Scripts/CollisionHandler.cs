using System.ComponentModel;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    float DelayInLoading = 1f;
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
                LoadNextLevel();
                break;
            default:
                Debug.Log("You Blew up");
                StartCrash();
                break;
        }
    }
    void StartCrash()
    {
        Invoke("ReloadLevel", DelayInLoading);
        GetComponent<Movement>().enabled = false;
    }
    void LoadNextLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;
        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 0;
        }
        SceneManager.LoadScene(nextSceneIndex);
    }
    void ReloadLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

}
