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
        affects game    
    */
    void Update()
    {

    }

    /*
        Method called upon collision of this collider with another one
    */
    private void OnTriggerEnter(Collider otherCollider)
    {
        if(otherCollider.compareTag(""))
        Debug.Log("Coin picked up!");
        Destroy(gameObject);

    }
}
