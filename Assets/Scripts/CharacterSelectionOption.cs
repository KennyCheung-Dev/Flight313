using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelectionOption : MonoBehaviour
{
    [SerializeField] private int myPosition;
    private CharSelectManager manager;
    private GameObject sceneManager;

    // Start is called before the first frame update
    void Start()
    {
        sceneManager = GameObject.FindGameObjectWithTag("SceneManager");
        manager = GameObject.FindGameObjectWithTag("01Manager").GetComponent<CharSelectManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        manager.Animate(myPosition);
        //print("Animating: " + myPosition);
    }

    public void Pressed()
    {
        if (myPosition == 0)
        {
            Debug.Log("Going To Passenger's Story");
            StartCoroutine(WaitForSeconds(0, 27));
        }
        else if (myPosition == 1)
        {
            Debug.Log("Going To FlightAttendant's Story");
            StartCoroutine(WaitForSeconds(0, 4));
        }
        else if (myPosition == 2)
        {
            Debug.Log("Going To Pilot's Story");
            StartCoroutine(WaitForSeconds(0, 66));
        }
    }
    IEnumerator WaitForSeconds(int i, int scene)
    {
        yield return new WaitForSeconds(i);
        sceneManager.GetComponent<MySceneManager>().SwitchScreen(scene);
    }
}
