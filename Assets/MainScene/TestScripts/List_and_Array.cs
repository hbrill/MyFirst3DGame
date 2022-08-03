using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List_and_Array : MonoBehaviour
{
    // Start is called before the first frame update
    public string[] SingersArray = new string[]{"Beyonce", "Mariah", "Rihanna"};
    public string[] ActressArray = new string[4];
    public List<int> Numbers = new List<int>();

    // C# ArrayLists allow for different data types to be stored
    ArrayList Inventory = new ArrayList();

    void Start()
    {
        
        
        Numbers.Add(4);
        Numbers.Add(10);
        Numbers.Add(1829);
        Numbers.Add(001);
        Numbers.Insert(2, 19); // inserts 19 to index 2. list becomes [4, 10, 19, 1829, 001]
        if(Numbers.Contains(4)){
            Numbers.Remove(4); // list is now [10, 19, 1829, 001]
        } 

        ActressArray[0] = "Lena";
        ActressArray[1] = "Lizzie";
        ActressArray[2] = "Danai";
        ActressArray[3] = "Lupita";
        Inventory.Add("Lizzie");
        Inventory.Add('A');
        Inventory.Add(4.7);
        Inventory.Add(23);
        Inventory.Add(true);
        Inventory.Add(GameObject.FindGameObjectsWithTag("Fireworks"));

        string GoatSinger = SingersArray[0]; //Beyonce
        string GoatActress = ActressArray[2];
        int WeirdNumber = Numbers[3]; // unlike in other languages, C# lists are accessed the same way as arrays
        GameObject[] Fireworks = Inventory[5] as GameObject[]; //interesting C# casting to array
        int numFireworks = Fireworks.Length;
        Debug.Log("My pick singer: " + GoatSinger);
        Debug.Log("My pick actress: " + GoatActress);
        Debug.Log("And Vecna is: " + WeirdNumber);
        Debug.Log(Inventory[0] + " has a grade " + Inventory[1] + ". Is graduating? " + Inventory[2] + ". GPA: " + Inventory[3] + " Age: " + Inventory[4]+ ". We'll detonate " + numFireworks + " fireworks for her.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
