using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimeNumbers : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] randomNumbers = new int[] {2,8,4,5,9,12,11,3,6};
        for(int j = 0; j < randomNumbers.Length; j++){
            Debug.Log("Is " + randomNumbers[j] + " a prime number? " + isPrime(randomNumbers[j]));
        }
        
    }

    // Update is called once per frame
    // Precondition: num shouldn't be 0 or 1
    bool isPrime(int num){
        bool isPrime = true;
        for(int i = 2; i <= num; i++){
            if(i != num && num % i == 0){
                isPrime = false;
            }
        }
        
        return isPrime;
    }
}
