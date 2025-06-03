using System.Collections;
using System.Threading;
using UnityEngine;

public class FirstCoroutine : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(ShowDebug());
        Debug.Log("In start after call of coroutine");
    }

    // ReSharper disable Unity.PerformanceAnalysis
    IEnumerator ShowDebug() // IEnumerator = Coroutine
    {
        yield return null; //waiting for 1 frame 
        yield return new WaitForSeconds(5f); // waiting for 5 seconds
        Debug.Log("Function was called");
    }
}
