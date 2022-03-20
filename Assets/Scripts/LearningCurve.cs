using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    private int CurrentAge = 19;
    public int AddedAge = 1;

    public float Pi = 3.14f;
    public string FirstName = "Lillian";
    public bool IsAuthor = true;
    public bool hasDungeonKey;
    public int currentGold = 0;
    public bool weaponEquipped = true;
    public string weaponName = "LongSword";
    public string CharAction = "Attack";
    int[] TopPlayerScores = {700,600,500};
    List<string> PartyMembers = new List<string>() {"Bob", "Indiana Bones", "Merlin the wizard"};
    Dictionary<string,int> ItemInventory = new Dictionary<string,int>() 
    {
        {"Potion",5},
        {"Sword",3},
        {"Goblins??",7},
    };

    Character2 hero = new Character2();
    Character2 heroine = new Character2("Agatha");
    //Weapon HuntingBow = new Weapon("Hunting bow",105);
    //Paladin knight = new Paladin("Sir Arthur", huntingBow);
    //Weapon WarBow = HuntingBow;
    //Character2 hero2 = hero;


    public Transform CamTransform;
    public GameObject DirectionalLight;
    public Transform LightTransform;


    // Start is called before the first frame update
    void Start()
    {   

        

        // CamTransform = this.GetComponent<Transform>();
        // Debug.Log(CamTransform.localPosition);

        //hero.PrintInfo();
      //  hero2.PrintInfo();
        //heroine.PrintInfo();
        //HuntingBow.PrintWeaponInfo();
      //  WarBow.PrintWeaponInfo();

        /*
        foreach (KeyValuePair<string,int> kvp in ItemInventory) {
            Debug.LogFormat("Item: {0} - {1}g",kvp.Key,kvp.Value);
        }

        for(int i = 0; i < PartyMembers.Count; i++) {
            Debug.Log(PartyMembers[i]);
        }

        foreach (string Member in PartyMembers) {
            Debug.Log(Member);
        }

        if(weaponEquipped) {
            if(weaponName == "Longsword") {
                Debug.Log("To battle!!");
            } else {
                Debug.Log("This won't end well...");
            }
        }

        switch(CharAction) {
            case "Attack":
                Debug.Log("To arms");
                break;
            case "Heal":
                Debug.Log("Healing");
                break;
            default:
                Debug.Log("Shield");
                break;
        }

        if(hasDungeonKey) {
            Debug.Log("You have the dungeon key and can enter");
        }
        else {
            Debug.Log("You aren't worthy yet");
        }

        Thievery();
        */
    }


    void Thievery() {
        if(currentGold > 50) {
            Debug.Log("you're rich!!");
        }
        else if (currentGold < 15){
            Debug.Log("Sheeshhh you kinda broke");
        } else {
            Debug.Log("Middle class energy");
        }
    }


    void ComputeAge() {
        Debug.Log(CurrentAge + AddedAge);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
