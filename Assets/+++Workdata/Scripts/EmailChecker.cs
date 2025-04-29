using System.Linq;
using MyBox;
using UnityEngine;
using System;

public class EmailChecker : MonoBehaviour
{
    [SerializeField] private string Username; 
    [SerializeField] private string EMail;


    [ButtonMethod]
    void CheckStrings()
    {
        //username atleast 8 characters, max 15 characters
        if (Username.Length >= 8 && Username.Length <= 15 && Username.All(Char.IsLetter)) //.All(Char.IsLetter) to force the tester to use Letters, other components won't work
        {
            Debug.Log("username accepted");
        }
        else
        {
            Debug.Log("username needs to have 8-15 characters and only contains letters.");
        }
        
        //email contains @, atleast 10 characters 
        if (EMail.Length >= 10 && EMail.Contains("@" ))
        {
            Debug.Log("email accepted");
        }
        else
        {
            Debug.Log("email needs to be at least 10 characters and needs an @.");
        }
    }
}
    
