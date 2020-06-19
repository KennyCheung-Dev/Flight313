using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneManager : MonoBehaviour
{
    public GameObject[] elementsToShow;
    [SerializeField] private int currentElement = 0;
    [SerializeField] private int nextIndex;
    private GameObject sceneManager;
    [SerializeField] private bool autoNextScreen = true;

    // Start is called before the first frame update
    void Start()
    {
        sceneManager = GameObject.FindGameObjectWithTag("SceneManager");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (currentElement == elementsToShow.Length)
            {
                if (autoNextScreen)
                {
                    sceneManager.GetComponent<MySceneManager>().SwitchScreen(nextIndex);
                }
            } else
            {
                elementsToShow[currentElement].SetActive(true);
                currentElement++;
            }
        }
    }
}
