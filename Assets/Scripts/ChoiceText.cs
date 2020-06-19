using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceText : MonoBehaviour
{

    [SerializeField] private string[] texts;
    private Text mText;
    private string currentText;
    public float timeCounter;
    public float timeLapse;
    public bool done = false;
    private bool goToEnd = false;
    public int currentIndex = 0;
    public GameObject choices;
    // Start is called before the first frame update
    void Start()
    {
        mText = GetComponent<Text>();
        //Replaced all the "^" to next line character
        for (int i = 0; i < texts.Length; i++)
        {
            texts[i] = texts[i].Replace('^', '\n');
        }
        if (texts.Length > 0) { 
            currentText = texts[0];
            StartCoroutine(BuildText());
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //If not done displaying text
            if (!done)
            {
                goToEnd = true;
                done = true;
            }
            else if (done)
            {
                if (currentIndex < texts.Length - 1)
                {
                    currentIndex += 1;
                    currentText = texts[currentIndex];
                    done = false;
                    goToEnd = false;
                    mText.text = "";
                    StartCoroutine(BuildText());

                }
                else if (currentIndex >= texts.Length - 1)
                {
                    //Whole Sequence Done
                    //Next Screen
                    //choices.SetActive(true);
                }
            }
        }
        if (done)
        {
            choices.SetActive(true);
        }
        else
        {
            choices.SetActive(false);
        }
    }

    private IEnumerator BuildText()
    {
        for (int i = 0; i < currentText.Length; i++)
        {
            if (goToEnd)
            {
                //Display the full text
                mText.text = currentText;
                //Skip to after the last character, so no more char will be concatenated
                i = currentText.Length;
            }
            try
            {
                mText.text = string.Concat(mText.text, currentText[i]);
            }
            catch (Exception e)
            {
                //print(e);
            }
            if (i >= currentText.Length - 1)
            {
                done = true;
            }
            else
            {
                done = false;
            }
            //Wait a certain amount of time, then continue with the for loop
            yield return new WaitForSeconds(timeLapse);
        }
    }
}
