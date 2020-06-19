using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextSceneByTime : MonoBehaviour
{
    private MySceneManager sceneManager;
    [SerializeField] private int nextIndex;
    [SerializeField] private float secondDelayed = 0;
    // Start is called before the first frame update
    void Start()
    {
        sceneManager = GameObject.FindGameObjectWithTag("SceneManager").GetComponent<MySceneManager>();
        StartCoroutine(NextSceneAfterSeconds(secondDelayed));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator NextSceneAfterSeconds(float i)
    {
        yield return new WaitForSeconds(i);
        sceneManager.SwitchScreen(nextIndex);

    }
}
