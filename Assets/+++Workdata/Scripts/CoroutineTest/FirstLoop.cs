using System.Collections;
using UnityEngine;

public class FirstLoop : MonoBehaviour
{
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
 
        
        
        //for (int i = 0; i < 5; i++)
        {
            StartCoroutine(Delay());
        }
        //Debug.Log("Loop ended");
    }

    IEnumerator Delay()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);   
        for (int i = 0; i < 5; i++)
        {
           
            cube.transform.Rotate(0, 0, -30);
            cube.transform.position += new Vector3(i, 0, 0);
            Debug.Log("Loop" + i);
            yield return new WaitForSeconds(1f);
        }
        Debug.Log("Loop ended");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
