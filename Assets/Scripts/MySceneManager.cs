using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MySceneManager : MonoBehaviour
{
    public GameObject[] screenList;
    public bool keyCardBrought = false;
    public bool drinkOffered = false;
    public bool grabToy = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    //00 - StartScreen
    //01 - CharacterSelectionScreen
    public void SwitchScreen(int scrn)
    {
        //Set All Screen Inactive
        foreach (GameObject screen in screenList)
        {
            screen.SetActive(false);
        }
        //Activate the screen based on input
        screenList[scrn].SetActive(true);
    }
}
