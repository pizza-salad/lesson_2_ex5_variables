using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guess : MonoBehaviour
{
    // Start is called before the first frame update
    public int num;
    void Start()
    {
        Debug.Log("num + 137 = " + (num + 137) + "\n");

        Debug.Log("num - 17 = " + (num - 17) + "\n");   

        Debug.Log("num * 5 = " + (num * 5) + "\n");

        Debug.Log("num / 3 = " + (num / 3.0) + "\n");

        Debug.Log("num % 7 = " + (num % 7) + "\n");

        Debug.Log("num * 3.75 = " + (num * 3.75) + "\n");

        Debug.Log("num > 50 than = " + (num > 50) + "\n");

        Debug.Log("num <= 10 = " + (num <= 10) + "\n");

        Debug.Log("num != 19 = " + (num != 19) + "\n");

        Debug.Log("! (num == 19) = " + (! (num == 19)) + "\n");

        Debug.Log("num % 3 == 0 || num % 4 == 0 = " + (num % 3 == 0 || num % 4 == 0) + "\n");


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
