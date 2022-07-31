using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VarScript : MonoBehaviour
{
    public int num1 = 3;
    public int num2 = 4 ;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return)){
            addNumbers(num1, num2);
        }
    }

    void addNumbers(int number1, int number2){
        Debug.Log("Sum is " + number1 + number2);
    }
}
