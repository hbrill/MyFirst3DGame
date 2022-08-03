using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If : MonoBehaviour
{
    public bool rainToday = false;
    // Start is called before the first frame update
    void Start()
    {
        if(rainToday){
            Debug.Log("Don't forget your umbrella");
        }else{
            Debug.Log("Enjoy the day outside!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
