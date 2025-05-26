using UnityEngine;

public class Vector : MonoBehaviour
{
    private Vector2 myFirstVector;
    private Vector2 mySecondVector;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myFirstVector = new Vector2(2, 3);
        mySecondVector = new Vector2(-3, 1);

        Vector2 vectorBetweenPoints = mySecondVector - myFirstVector; 
            
        Debug.Log(vectorBetweenPoints);
        
        Vector2 reconstructmySecondVector = myFirstVector +  vectorBetweenPoints;
        Vector2 reconstructmyFirstVector = mySecondVector - vectorBetweenPoints;
        
        Debug.Log(reconstructmyFirstVector);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
