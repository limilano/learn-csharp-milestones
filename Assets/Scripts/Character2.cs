using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character2 {
    public string name;
    public int exp = 0;
    
    public Character2() {
        name = "Not assigned";
    }
    
    public Character2(string name) {
        this.name = name;
    }

    public virtual void PrintInfo() {
        Debug.LogFormat("Hero: {0} - {1} EXP", name,exp);
    }

}

/**
public class Paladin: Character2 {
    public Weapon;

    public Paladin(string name, Weapon weapon): base(name) {
         this.weapon = weapon;
    }
}
**/