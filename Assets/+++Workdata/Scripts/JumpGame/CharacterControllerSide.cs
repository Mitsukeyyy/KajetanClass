using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterControllerSide : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private float direction = 3f;
    [SerializeField] private float jumpHeight = 3f;


    private Rigidbody2D rb;

    [Header("GroundCheck")] [SerializeField]
    private Transform transformGroundCheck;

    [SerializeField] private LayerMask layerGround;

    [SerializeField] CoinManager coinmanager;
    [SerializeField] UI_Manager uimanager;

    private bool canMove = true; 



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {


            direction = 0f;

            if (Keyboard.current.aKey.isPressed)
            {
                direction = -1;
            }

            if (Keyboard.current.dKey.isPressed)
            {
                direction = 1;
            }

            if (Keyboard.current.spaceKey.isPressed)
            {
                Jump();
            }

            //transform.position += direction.normalized * (Time.deltaTime * speed);

            rb.linearVelocity = new Vector2(direction * speed, rb.linearVelocity.y);
        }
    }

    void Jump()
    {
        {
            if (Physics2D.OverlapCircle(transformGroundCheck.position, 0.3f, layerGround))
                rb.linearVelocity = new Vector2(0, jumpHeight);
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
            
        } else if (other.CompareTag("obstacle"))
        {
            Debug.Log("Es war ein obstacle");
            uimanager.ShowPanelLost();
            rb.linearVelocity = Vector2.zero; 
            canMove = false;
        }
    }
}