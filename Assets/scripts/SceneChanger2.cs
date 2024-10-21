using UnityEngine;
using UnityEngine.SceneManagement; 

public class SceneChanger2 : MonoBehaviour
{
    private bool isPlayerNearby = false; 

    void Update()
    {
        if (isPlayerNearby && Input.GetKeyDown(KeyCode.E))
        {
            ChangeScene(); 
        }
    }

    private void ChangeScene()
    {
        SceneManager.LoadScene("NoteScene");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNearby = true; 
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNearby = false; 
        }
    }
}
