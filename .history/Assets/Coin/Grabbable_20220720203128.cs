// namespaces aka libraries we'll be using
using System.Collections;
using UnityEngine;

public class Grabbable : MonoBehaviour
{
    /* static means that only one of copy of the variable will be created
    public static counter;
    
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
        /* 
        to avoid other game objects such as bullets, cars etcetera from
        picking up coins too, we set it so that only a game object with a
        tag set to player can pickup the coin
        */
        if(otherCollider.CompareTag("Player") == true){
            Debug.Log("Coin picked up!");
            Destroy(gameObject);
        }
        

    }
}
