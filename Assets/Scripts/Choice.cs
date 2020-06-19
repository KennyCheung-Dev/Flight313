using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Choice : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Animator myAnim;
    private MySceneManager sceneManager;
    [SerializeField] private int targetScreen;
    public string flag = "";
    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
        sceneManager = GameObject.FindGameObjectWithTag("SceneManager").GetComponent<MySceneManager>();
    }

    public void OnButtonClick()
    {
        //Flags for flight Attendant
        if (flag == "keyCard")
        {
            sceneManager.keyCardBrought = true;
        } else if (flag == "alcoholOffered")
        {
            sceneManager.drinkOffered = true;
        }
        if (flag == "refused")
        {
            sceneManager.drinkOffered = false;
        }

        //Flags for Passenger
        if (flag == "grabToy")
        {
            sceneManager.grabToy = true;
        }

        //Switch Scene
        sceneManager.GetComponent<MySceneManager>().SwitchScreen(targetScreen);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //print("mouseOver");
        myAnim.SetBool("hover", true);

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //print("mouseOverGone");
        myAnim.SetBool("hover", false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
