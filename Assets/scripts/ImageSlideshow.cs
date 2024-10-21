using UnityEngine;
using UnityEngine.UI; 
using System.Collections.Generic; 
using UnityEngine.SceneManagement; 

public class RawImageSlideshow : MonoBehaviour
{
    public List<Texture> images; 
    public RawImage displayImage; 
    public GameObject confirmPopup; 
    public GameObject realPopup; 
    public Button yesButton; 
    public Button noButton; 
    public Button yesButton1; 
    public Button noButton1; 

    private int currentIndex = 0; 

    void Start()
    {
        if (images.Count > 0)
        {
            displayImage.texture = images[currentIndex]; 
        }

        confirmPopup.SetActive(false); 
        realPopup.SetActive(false); 
        yesButton.gameObject.SetActive(false); 
        noButton.gameObject.SetActive(false); 
        yesButton1.gameObject.SetActive(false); 
        noButton1.gameObject.SetActive(false); 

        yesButton.onClick.AddListener(ShowRealPopup); 
        noButton.onClick.AddListener(ChangeScenemenu); 
        yesButton1.onClick.AddListener(ChangeScene); 
        noButton1.onClick.AddListener(ChangeScenemenu); 
        Cursor.visible = true; 
        Cursor.lockState = CursorLockMode.None; 
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && currentIndex < images.Count - 1)
        {
            NextImage(); 
        }
        else if (currentIndex == images.Count - 1 && Input.GetKeyDown(KeyCode.Space))
        {
            ShowConfirmPopup(); 
            displayImage.gameObject.SetActive(false); 
        }
        {
    if (Input.GetMouseButtonDown(0)) 
    {
        HandleMouseClick();
    }
}
    }

    void NextImage()
    {
        currentIndex++; 
        if (currentIndex < images.Count)
        {
            displayImage.texture = images[currentIndex]; 
        }
        else
        {
            ShowConfirmPopup(); 
        }
    }

    void ShowConfirmPopup()
    {
        confirmPopup.SetActive(true); 
        yesButton.gameObject.SetActive(true); 
        noButton.gameObject.SetActive(true); 
    }

    void HideConfirmPopup()
    {
        confirmPopup.SetActive(false); 
        yesButton.gameObject.SetActive(false); 
        noButton.gameObject.SetActive(false); 
    }

    void ShowRealPopup()
    {
        HideConfirmPopup();
        realPopup.SetActive(true); 
        yesButton1.gameObject.SetActive(true); 
        noButton1.gameObject.SetActive(true); 
    }

    void HideRealPopup()
    {
        realPopup.SetActive(false); 
        yesButton1.gameObject.SetActive(false); 
        noButton1.gameObject.SetActive(false); 
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("Badend"); 
    }
    void ChangeScenemenu()
    {
        SceneManager.LoadScene("goodend");
    }
    public void OnButtonClick()
{
    Debug.Log("Button clicked!");
}
void HandleMouseClick()
{
    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    RaycastHit hit;

    if (Physics.Raycast(ray, out hit))
    {
        if (hit.collider != null)
        {
            Debug.Log("Clicked on: " + hit.collider.gameObject.name);
        }
    }
}
}
