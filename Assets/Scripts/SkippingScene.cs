using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkippingScene : MonoBehaviour
{
    private MySceneManager sceneManager;
    [SerializeField] private int nextIndex;
    [SerializeField] private string flag;
    // Start is called before the first frame update
    void Start()
    {
        sceneManager = GameObject.FindGameObjectWithTag("SceneManager").GetComponent<MySceneManager>();
        if (flag == "drinkOffered" && sceneManager.drinkOffered == true)
        {
            sceneManager.SwitchScreen(nextIndex);
        }
        if (flag == "grabToy" && sceneManager.grabToy == true)
        {
            sceneManager.SwitchScreen(nextIndex);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
