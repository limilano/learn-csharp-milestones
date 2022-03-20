using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehvaior : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEvent(Collider other) {
        if(other.name == "Player") {
            Debug.Log("Are you doing tasks rn??");
        }
    }

    void onTriggerExit(Collider other) {
        if(other.name == "Player") {
            Debug.Log("If you see anything, call an emergency meeting");
        }
    }
}
