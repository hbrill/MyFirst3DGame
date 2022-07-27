// namespaces aka libraries we'll be using
using System.Collections;
using UnityEngine;

public class Grabbable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game on, let's go!");
    }

    /* Update is called once per frame
        Avoid executing heavy complex tasks in this block
        as the Update method execute once per frame and this
        affects game performance
    */
    void Update()
    {

    }

    private void OnTriggerEnter(Collider otheCollider)
    {
        Debug.Log("Something has collided with the coin");
    }
}
