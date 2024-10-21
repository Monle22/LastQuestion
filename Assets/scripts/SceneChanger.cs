using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string sceneToLoad;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeScene();
        }
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
