using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    /*
    The f is added to indicate that it is indeed a float and not an integer.
    This variable here can be seen in the game object it is assigned to on the Unity GUI. However, the
    VALID value is whichever value is assigned on the GUI. This here is essentially a default if it isn't
    changed, but if it gets changed on the GUI that value overrides this one.
    */
    public float maxTime = 60f;

    // Now, we'll create a separate variable that will make the current count private so that it cannot be
    // changed
    private float countdown = 0;
    // Start is called before the first frame update
    void Start()
    {
        countdown = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        /*
         deltaTime stands for the time in seconds that has passed between the render of the current frame from the previous frame
         i.e deltaTime is the lapse of time between our current frame and our previous frame.
         If frame1 renders, 3.5 seconds pass and frame2 renders, our deltaTime will be 3.5
        */
        countdown -= Time.deltaTime; 
    }
}
