using UnityEngine;
using UnityEngine.UI; 
public class ItemInteraction : MonoBehaviour
{
    public GameObject textMessage; 
    private bool isNearItem = false;

    void Start()
    {
        
        textMessage.SetActive(false);
    }

    void Update()
    {
        
        if (isNearItem && Input.GetKeyDown(KeyCode.E))
        {
            
            Debug.Log("Picked up the item!");

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
