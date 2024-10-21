using UnityEngine;

public class PopupManager : MonoBehaviour
{
    public GameObject popup; 
    public TMPro.TextMeshProUGUI closetext;


    void Start()
    {
        popup.SetActive(true); 
        closetext.gameObject.SetActive(true);
    }

    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ClosePopup(); 
            Closeclosetext();
        }
    }

    void ClosePopup()
    {
        popup.SetActive(false); 
    }
    void Closeclosetext()
    {
        closetext.gameObject.SetActive(false);
    }
}
