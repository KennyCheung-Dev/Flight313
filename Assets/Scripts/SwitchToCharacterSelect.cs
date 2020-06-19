using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchToCharacterSelect : MonoBehaviour
{
    private GameObject sceneManager;
    [SerializeField] private Image panel;
    private bool fade = false;
    // Start is called before the first frame update
    void Start()
    {
        sceneManager = GameObject.FindGameObjectWithTag("SceneManager");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            fade = true;
            StartCoroutine(WaitForSeconds(2));

        }
        if (fade)
        {
            if (panel.color.a < 1.0)
            {
                panel.color = new Color(panel.color.r, panel.color.g, panel.color.b, panel.color.a + 0.01f);
            }
        }
    }





    IEnumerator WaitForSeconds(int i)
    {
        yield return new WaitForSeconds(i);
        panel.color = new Color(panel.color.r, panel.color.g, panel.color.b, 0);
        sceneManager.GetComponent<MySceneManager>().SwitchScreen(1);
    }
}
