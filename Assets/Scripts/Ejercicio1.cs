using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    public int num1 = 0;
    void Start()

    {
        num1 = num1 + 2;
        Debug.Log(num1);

        num1 = num1 * num1;
        Debug.Log(num1);
    }
    
    
}
