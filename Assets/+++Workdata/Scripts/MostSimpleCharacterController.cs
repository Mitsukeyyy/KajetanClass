using System;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class MostSimpleCharacterController : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    private int counterInt = 0;
    public TextMeshProUGUI counter;
    private Vector3 direction = new Vector3(0f, 0f);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        counter.text = counterInt.ToString();
    }

    // Update is called once per frame
    void Update()
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


    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Wir sind mit etwas kollidiert");
        if (other.CompareTag("coin"))
        {
            Debug.Log("es war eine Münze");
            Destroy(other.gameObject);
            counterInt++;
            counter.text = counterInt.ToString();
            //Debug.Log(counterInt);
        }
        
    }
  
}
