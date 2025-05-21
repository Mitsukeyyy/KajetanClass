using System;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class MostSimpleCharacterController : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    private Vector3 direction = new Vector3(0f, 0f);

    [SerializeField] private CoinManager coinmanager; //add variable to use function from a different script
    [SerializeField] private UI_Manager uimanager;

    private bool canMove = true;
 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            transform.position += direction.normalized * (Time.deltaTime * speed);
        
            direction = Vector3.zero;

            if (Keyboard.current.wKey.isPressed)
            {
                direction.y = 1;
            }
            if (Keyboard.current.sKey.isPressed) 
            {
                direction.y = -1;
            }
            if (Keyboard.current.aKey.isPressed) 
            {
                direction.x = -1;
            }
            if (Keyboard.current.dKey.isPressed) 
            {
                direction.x = 1;
                // or Vector3.right to move in the right direction
            }
        }  
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Wir sind mit etwas kollidiert");
        if (other.CompareTag("coin"))
        {
            Debug.Log("es war eine Münze");
            Destroy(other.gameObject);
            coinmanager.AddCoin();

        }

        else if (other.CompareTag("obstacle"))
        {
            Debug.Log("Es war ein obstacle");
            //TODO: show lostscreen and disable movement 
            uimanager.ShowPanelLost();
            canMove = false;   
        }
        
    }
  
}
