using MyBox;
using UnityEngine;
using UnityEngine.InputSystem;

public class CreatingSimpleObjects : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private float size = 3f;
    private GameObject goSphere;
    private GameObject goSphere2;
    private GameObject goSphere3;
    private GameObject goSphere4;
    private GameObject goSphere5;

    private Vector3 direction = new Vector3(0f, 0f);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        goSphere = GameObject.CreatePrimitive(PrimitiveType.Cube);
        goSphere2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        goSphere3 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        goSphere4 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        goSphere5 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        goSphere.transform.position = new Vector2(2, 0);
        
      

        //goSphere.transform.position = goSphere.transform.position + new Vector3(-4, 0, 0);
        

    }

    void Update()
    {
        goSphere.transform.position = goSphere.transform.position + direction.normalized * (Time.deltaTime * speed); //deltaTime describes the time in ms that passed since the last frame, usage to work 
        // direction.normalized to shorten it to 1 at any time. 
        float currentScale = goSphere.transform.localScale.x;
        goSphere2.transform.position = goSphere.transform.position + new Vector3(1, 1, 0) * currentScale;
        goSphere3.transform.position = goSphere.transform.position + new Vector3(-1, 1, 0) * currentScale;
        goSphere4.transform.position = goSphere.transform.position + new Vector3(1, -1, 0) * currentScale;
        goSphere5.transform.position = goSphere.transform.position + new Vector3(-1, -1, 0) * currentScale;

        
        
        //movement
        
        if (Keyboard.current.spaceKey.wasPressedThisFrame) //assign a button
        {
            direction = Vector3.zero;
            Debug.Log("Space was pressed");
        }
        
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

        //-----scaling
        
        if (Keyboard.current.qKey.wasPressedThisFrame)
        {
            goSphere.transform.localScale = Vector3.one * size; //scaling an object 
        }
        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            goSphere.transform.localScale = Vector3.one; //scaling an object to the default size (.one)
        }

        //-----rotation
        
        if (Keyboard.current.rKey.isPressed)
        {
            //goSphere.transform.eulerAngles = new Vector3(0, 0, 45); //eulerAngles to use Vector 3 on rotations use the z axes to rotate an object within a 2D space
            //used to tdeclare a roation for the object while .Rotate is used to rotate the angle 
            
            goSphere.transform.Rotate(new Vector3(0, 0, 90) * Time.deltaTime);
        }
        
    }
    
}
