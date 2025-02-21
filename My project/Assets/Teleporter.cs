using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter : MonoBehaviour
{
    [SerializeField] int sceneIndex;

    private void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        sceneIndex = currentScene.buildIndex;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            changeScene();
    }

    private void changeScene()
    {
        switch(sceneIndex)
        {
            case 0:
                SceneManager.LoadSceneAsync("TestMainScene");
                break;
            case 1:
                break;
        }
    }
}
