using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    // free choice for the names, public ones capital privates lower
    private bool myFirstBoolean;
    private int myFirstInteger;
    private int mySecondInteger;
    private string myFirstString;

    private float myFirstFloat = 3.5f; 
    private char myFirstChar = 'a';
    
    private int counter;
    
    private GameObject myGameObject; //a unity gameobject - empty, we can add an object from our
                                     //hierarchy to make it functional within the script 

    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   
        Debug.Log("Das Programm ist gestartet");

        myFirstBoolean = true;
        myFirstInteger = 9;
        mySecondInteger = 7;
        myFirstString = "Moin das ist ein String";

        
        


        Debug.Log("myFirstBool is: " + myFirstBoolean);
        Debug.Log("myFirstInteger is " + myFirstInteger);
        Debug.Log("myFirstString is " + myFirstString);

        int result = myFirstInteger + mySecondInteger;
        int result2 = myFirstInteger - mySecondInteger;
        int result3 = myFirstInteger * mySecondInteger; 
        float result4 = (float) myFirstInteger / mySecondInteger; // (float) is a cast -> switches up the variable  
        int result5 = myFirstInteger % mySecondInteger;
        Debug.Log(" int1 + int2 " + result);
        Debug.Log(" int1 - int2 " + result2);
        Debug.Log(" int1 * int2 " + result3);
        Debug.Log(" int1 / int2 " + result4);
        Debug.Log(" int1 % int2 " + result5); //% = rest from 2 divided ints
        Debug.Log("int1 + int2 =" + result + " int1 - int2 =" + result2 + " int1 * int2 =" + result3 + " int1 / int2 =" + result4 + " int1 % int2 =" + result5);
        
        // MyFirstFunction(); // hier rufen wir unsere erste Funktion auf 
        
        Debug.Log("Start ist zu Ende");

        //result = result + 1;
        //result += 1;
        result++;
        Debug.Log("result +1 = " + result); 
        
    }

    // Update is called once per frame
    // void Update()
    // {
    //     Debug.Log("Das Programm läuft" + counter);
    //     counter++;
    // }

    public void MyFirstFunction() // Funktion angelegt, Public um Funktion in Unity zu sehen  
    {
        Debug.Log("Meine Funktion wurde aufgerufen");
    }
}
