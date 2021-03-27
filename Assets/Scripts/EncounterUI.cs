using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncounterUI : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject attackButton;
    GameObject talkButton;
    GameObject[] characters;
    void Start()
    {
        attackButton = GameObject.Find("AttackButton");
        talkButton = GameObject.Find("TalkButton");
        characters = GameObject.FindGameObjectsWithTag("Character");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void hideButtons() {
        attackButton.SetActive(false);
        talkButton.SetActive(false);
    }
    public void onAttack() {
        hideButtons();
        foreach (GameObject character in characters)
        {
            character.GetComponent<Enemy>().aggro = true;
        }
    }

    public void onTalk()
    {
        hideButtons();
    }
}
