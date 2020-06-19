using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class QuitGame : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Animator myAnim;

    public void Start()
    {
        myAnim = GetComponent<Animator>();
    }

    public void OnButtonClicked()
    {
        print("QuittingGame");
        Application.Quit();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        myAnim.SetBool("hover", true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        myAnim.SetBool("hover", false);
    }
}
