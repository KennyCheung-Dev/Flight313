using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CreditButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Animator myAnim;
    public GameObject creditBox;

    public void Start()
    {
        myAnim = GetComponent<Animator>();
    }

    public void OnButtonClicked()
    {
        creditBox.SetActive(!creditBox.activeSelf);
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
