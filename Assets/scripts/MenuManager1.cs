using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager1 : MonoBehaviour
{
    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu"); 
    }
}