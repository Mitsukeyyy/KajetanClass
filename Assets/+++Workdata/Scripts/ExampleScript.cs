using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    // free choice for the names, public ones capital privates lower
    private bool myFirstBoolean;
    private int myFirstInteger;
    private int mySecondInteger;
    private string myFirstString;

    private int counter;

    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   
        Debug.Log("Das Programm ist gestartet");

        myFirstBoolean = true;
        myFirstInteger = 1;
        mySecondInteger = 5;
        myFirstString = "Moin das ist ein String";

        int result = myFirstInteger + mySecondInteger;
        


        Debug.Log("myFirstBool is: " + myFirstBoolean);
        Debug.Log("myFirstInteger is " + myFirstInteger);
        Debug.Log("myFirstString is " + myFirstString);
        Debug.Log(" int1 + int2 " + result);
        // MyFirstFunction(); // hier rufen wir unsere erste Funktion auf 
        
        Debug.Log("Start ist zu Ende");

        //result = result + 1;
        //result += 1;
        result++;
        Debug.Log("result +1 = " + result); 
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Das Programm läuft" + counter);
        counter++;
    }

    public void MyFirstFunction() // Funktion angelegt, Public um Funktion in Unity zu sehen  
    {
        Debug.Log("Meine Funktion wurde aufgerufen");
    }
}
