using MyBox;
using UnityEngine;

public class IfAndElse : MonoBehaviour
{

    [SerializeField] int IfInteger = 6; //SerializeField means you can change them in the inspector
    [SerializeField] private float IfFloat = 4.3f;
    
    [ButtonMethod] //adds a button in the inspector to execute a function again 
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if ((IfInteger > 5 && IfInteger < 10) || IfInteger == 20) //If -> (condition) then execute within [brackets}
                                             //   || -> OR condition
                                             // need double (if there are multiple conditions for one execution)
        {
            Debug.Log("My Integer is between 5 and 10 or it's 20");
        }
        else
        {
            Debug.Log("Integer is smaller than 5");
        }
            
        //Debug.Log("first int = " + IfInteger);
        Debug.Log("first float = " +IfFloat);
    }
    
     

    // Update is called once per frame
    void Update()
    {
        
    }
}
