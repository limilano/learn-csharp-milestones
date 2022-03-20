using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameBehavior : MonoBehaviour
{
    public int MaxItems = 4;

    public Text HealthText;
    public Text ItemText;
    public Text ProgressText;

    public Button WinButton;

    public int _itemsCollected = 0;
    private int _playerHP = 10;

    public int Items {
        get { return _itemsCollected; }
        set {
            _itemsCollected = value;
            ItemText.text = "Items Collected: " + Items;

            if(_itemsCollected >= MaxItems) {
                ProgressText.text = "You've found all the items!";

                WinButton.gameObject.SetActive(true);
                
                Time.timeScale = 0f;
            } else {
                ProgressText.text = "Item found, only " + (MaxItems - _itemsCollected) + " more to go!";
            }
        }
    }

    public void RestartScene() {
        SceneManager.LoadScene(0);

        Time.timeScale = 1f;
    }

    public int HP {
        get { return _playerHP; }
        set {
            _playerHP = value;
            
            HealthText.text = "Player Health: " + HP;

            Debug.LogFormat("Lives: {0}",_playerHP);
        }
    }

   
    
    // Start is called before the first frame update
    void Start()
    {
        ItemText.text += _itemsCollected;
        HealthText.text += _playerHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
