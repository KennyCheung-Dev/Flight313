using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideOptions : MonoBehaviour
{

    public GameObject optionBox;
    public GameObject creditBox;
    // Start is called before the first frame update
    public void OnButtonClicked()
    {
        creditBox.SetActive(false);
        optionBox.SetActive(false);

    }
}
