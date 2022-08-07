using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Students : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Person studentOne = new Person(20, "Carla", "Roson", true, null);
        Person studentTwo = new Person(19, "Lucrecia", "Monzante", false, null);
        Person studentThree = new Person(19, "Lucas", "Parker", true, studentOne);
        studentOne.setPartner(studentThree);
        Debug.Log("Student one is " + studentOne.getFirstName() + ". Has partner? " + studentOne.getHasPartner() + ". Partner: " + studentOne.getPartner().getFirstName());
        //Debug.Log("Student two is " + studentTwo.firstName + ". Has partner? " + studentTwo.hasPartner + ". Partner: " + studentTwo.partner.firstName);
        Debug.Log("Student three is " + studentThree.getFirstName() + ". Has partner? " + studentThree.getHasPartner() + ". Partner: " + studentThree.getPartner().getFirstName());
        Debug.Log(studentOne.isPartner(studentThree));
        Debug.Log(studentTwo.isPartner(studentOne));
        Debug.Log(studentOne.isPartner(studentTwo));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
