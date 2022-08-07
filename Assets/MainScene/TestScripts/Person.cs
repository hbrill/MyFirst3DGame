using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person
{
    private int age;
    private string firstName;
    private string lastName;
    private bool hasPartner;
    private Person partner;

    public Person(int age, string firstName, string lastName, bool hasPartner, Person partner){
        this.age = age;
        this.firstName = firstName;
        this.lastName = lastName;
        this.hasPartner = hasPartner;
        this.partner = partner;
    }

    public void setFirstName(string fName){
        this.firstName = fName;
    }

    public string getFirstName(){
        return firstName;
    }

    public void setLastName(string lName){
        this.lastName = lName;
    }

    public string getLastName(){
        return this.lastName;
    }
    
    public void setAge(int pAge){
        this.age = pAge;
    }

    public int getAge(){
        return this.age;
    }
    
    public void getStatus(bool pHasPartner){
        this.hasPartner = pHasPartner;
    }

    public bool getHasPartner(){
        return hasPartner;
    }
    
    public void setPartner(Person partner){
        this.partner = partner;
    }

    public Person getPartner(){
        return partner;
    }

    public string isPartner(Person otherPerson){
        string isCouple = ""; 
        if(partner != null){
            if(otherPerson.getFirstName() == this.partner.getFirstName() && otherPerson.getLastName() == this.partner.getLastName()){
                isCouple = otherPerson.getFirstName() + " is " + this.getFirstName() + "'s partner.";
            }else{
                isCouple = otherPerson.getFirstName() + " is not " + this.getFirstName() + "'s partner.";
            }
        }else{
            isCouple = this.getFirstName() + " doesn't have a partner.";
        }
        
        return isCouple;
    }
    
}
