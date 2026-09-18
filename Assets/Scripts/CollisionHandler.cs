using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    AudioSource audioSource;
    float DelayInLoading = 1f;
    [SerializeField] GameObject cube;
    [SerializeField] AudioClip DeathSFX;
    [SerializeField] AudioClip SuccessSFX;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "friendly":
                Debug.Log("This thing is friendly");
                break;
            case "Finish":
                Debug.Log("congratulations! you have reached finish point");
                StartSuccess();
                break;
            default:
                Debug.Log("You Blew up");
                StartCrash();
                break;
        }
    }
    void StartCrash()
    {
        audioSource.PlayOneShot(DeathSFX);
        Invoke("ReloadLevel", DelayInLoading);
        GetComponent<Movement>().enabled = false;
    }
    void StartSuccess()
    {
        audioSource.PlayOneShot(SuccessSFX);
        Invoke("LoadNextLevel", DelayInLoading);
        GetComponent<Movement>().enabled = false;
    }
    void ReloadLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
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

}