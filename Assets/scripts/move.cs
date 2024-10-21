using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
     public float speed = 5f;


    // Start is called before the first frame update
    void Start()
    {
        

    }
        void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");


        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical).normalized;

        if (movement.magnitude > 0)
        {
            transform.position += movement * speed * Time.deltaTime;

            Quaternion targetRotation = Quaternion.LookRotation(movement);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, 720 * Time.deltaTime);
        }
    }
}
