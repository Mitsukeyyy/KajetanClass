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

    private Vector3 direction = new Vector3(3f, 1f);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        goSphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        goSphere2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        goSphere3 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        goSphere4 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        goSphere5 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        goSphere.transform.position = new Vector2(2, 0);
        
      

        //goSphere.transform.position = goSphere.transform.position + new Vector3(-4, 0, 0);
        

    }

    void Update()
    {
        goSphere.transform.position = goSphere.transform.position + direction * (Time.deltaTime * speed); //deltaTime describes the time in ms that passed since the last frame, usage to work 
        
        float currentScale = goSphere.transform.localScale.x;
        goSphere2.transform.position = goSphere.transform.position + new Vector3(1, 1, 0) * currentScale;
        goSphere3.transform.position = goSphere.transform.position + new Vector3(-1, 1, 0) * currentScale;
        goSphere4.transform.position = goSphere.transform.position + new Vector3(1, -1, 0) * currentScale;
        goSphere5.transform.position = goSphere.transform.position + new Vector3(-1, -1, 0) * currentScale;

        if (Keyboard.current.spaceKey.wasPressedThisFrame) //assign a button
        {
            direction = new Vector3(0, 0, 0);
            Debug.Log("Space was pressed");
        }

        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            direction = new Vector3(0, 1, 0);
        }
        if (Keyboard.current.sKey.wasPressedThisFrame) 
        {
            direction = new Vector3(0, -1, 0);
        }
        if (Keyboard.current.aKey.wasPressedThisFrame) 
        {
            direction = new Vector3(-1, 0, 0 );
        }
        if (Keyboard.current.dKey.wasPressedThisFrame) 
        {
            direction = new Vector3(1, 0, 0);
            // or Vector3.right to move in the right direction
        }

        if (Keyboard.current.qKey.wasPressedThisFrame)
        {
            goSphere.transform.localScale = Vector3.one * size; //scaling an object 
        }
        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            goSphere.transform.localScale = Vector3.one; //scaling an object 
        }
    }
    
}
