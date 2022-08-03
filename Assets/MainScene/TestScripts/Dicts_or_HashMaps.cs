using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dicts_or_HashMaps : MonoBehaviour
{
    public Hashtable studentDetails = new Hashtable();

    // Start is called before the first frame update
    void Start()
    {
        studentDetails.Add("firstName", "Bobby");
        studentDetails.Add("lastName", "Drake");
        studentDetails.Add("age", 32);
        studentDetails.Add("codeName", "Iceman");
        studentDetails.Add("omegaLevel", false);
        Debug.Log("His name is " + studentDetails["firstName"] + " " + studentDetails["lastName"] + ". He's " + studentDetails["age"] + ". His codename is " + studentDetails["codeName"] + ".");
        
        // best practice to check if key exists before attempting to do anything with it
        if(studentDetails.Contains("omegaLevel")){ 
            if((bool) studentDetails["omegaLevel"]){
                Debug.Log("He is omega level.");
            }else{
                Debug.Log("He isn't omega level.");
            } 
        }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
