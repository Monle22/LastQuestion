using UnityEngine;
using UnityEngine.UI; 

public class ItemCollector1 : MonoBehaviour
{
    public GameObject textMessage; 
    private bool isNearItem = false;
    public int itemValue = 1; 

    void Start()
    {
        textMessage.SetActive(false);
    }

    void Update()
    {
        if (isNearItem && Input.GetKeyDown(KeyCode.F))
        {
            ScoreManager.Instance.AddScore(itemValue); 
            
            gameObject.SetActive(false);
            
            textMessage.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            isNearItem = true;
            textMessage.SetActive(true); 
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            isNearItem = false;
            textMessage.SetActive(false); 
        }
    }
}
