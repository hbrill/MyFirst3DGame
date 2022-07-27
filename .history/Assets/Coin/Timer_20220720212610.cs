using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    /*
    The f is added to indicate that it is indeed a float and not an integer.
    This variable here can be seen in the game object it is assigned to on the Unity UI. However, the
    VALID value is whichever value is assigned on the UI. This here is essentially a default if it isn't
    changed, but if it gets changed on the GUI  
    */
    public float maxTime = 60f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
