// namespaces aka libraries we'll be using
using System.Collections;
using UnityEngine;

public class Coin : MonoBehaviour
{
    /* 
        static means that only one of copy of the variable will be created
        for all instances
    */
    public static int coinsCounter = 0;
    
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
            Coin.coinsCounter++;
            // you must destroy AFTER everything else, once a game object
            // is destroyed, so are the scripts and properties associated with it
            Destroy(gameObject); 
            
        }
        

    }
}
