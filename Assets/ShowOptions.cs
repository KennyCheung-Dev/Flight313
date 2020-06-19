using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShowOptions : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Animator myAnim;
    public GameObject optionBox;
    public GameObject creditBox;

    public void OnPointerEnter(PointerEventData eventData)
    {
        myAnim.SetBool("hover", true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        myAnim.SetBool("hover", false);
    }

    public void OnButtonClicked()
    {
        optionBox.SetActive(!optionBox.activeSelf);
        creditBox.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
