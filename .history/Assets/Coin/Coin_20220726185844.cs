// namespaces aka libraries we'll be using
using System.Collections;
using UnityEngine;

public class Coin : MonoBehaviour
{
    /* 
        static means that only one of copy of the variable will be created for all instances. Hence,
         whatever changes to the variable are made by one instance will be applied
        to all the other ones.
    */
    public static int coinsCounter = 0;
    
    /*
     Start is called before the first frame update
     As each game object renders this executes, i.e this will print the log once for every instance of
     a coin. Similarly, it'll increase the number of coins, i.e coinsCounter by one allowing us to have
     the total number of coins in the map.
    */
    void Start()
    {
        Debug.Log("Game on, let's go!");
        Coin.coinsCounter++;
        
    }

    /*  
        Update is called once per frame. Avoid executing heavy complex tasks in this block as the Update
        method execute once per frame and this affects game performance
    */
    void Update()
    {

    }

   
    // Method called upon collision of this collider with another one
    private void OnTriggerEnter(Collider otherCollider)
    {
        /* 
        To avoid other game objects such as bullets, cars etcetera from
        picking up coins too, we set it so that only a game object with a
        tag set to player can pickup the coin
        */
        if(otherCollider.CompareTag("Player") == true)
        {
            // We decrease the number of coins by one for every coin we pick up'
            Coin.coinsCounter--;
            Debug.Log("Coin picked up! There are " + Coin.coinsCounter + " coins left");
           
            if(Coin.coinsCounter == 0){
                Debug.Log("You've beaten the timer and picked up all coins, good job!");
                /* The next line will create a new game object and assign it whatever
                game object in our scene matches the name passed to find */
                GameObject gameManager = GameObject.Find("GameManager");
                
                /* To stop countdown we can simply destroy the GameManager since the timer
                is simply a script attached to the game object GameManager. Recall that once
                a game object is destroyed so is everything attached to it, such as scripts.
                */
                Destroy(gameManager);
            }
            /* you must destroy the game object AFTER everything else, once a game object
            is destroyed, so are the scripts and properties associated with it. This can generate
            unexpected behavior as seen previously when trying to track the number of coins */
            Destroy(gameObject); 
            GameObject [] fireworksSystem = GameObject,FindGameObjectsWithTag
            
        }
        

    }
}
