using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockPanel : MonoBehaviour
{
    private MySceneManager sceneManager;
    public string flag = "";
    // Start is called before the first frame update
    void Start()
    {
        sceneManager = GameObject.FindGameObjectWithTag("SceneManager").GetComponent<MySceneManager>();
        if (flag == "keyCard")
            if (sceneManager.keyCardBrought == true)
            {
                Destroy(gameObject);
            }
    }
}
