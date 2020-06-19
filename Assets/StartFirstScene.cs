using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFirstScene : MonoBehaviour
{
    public SwitchToCharacterSelect firstScreen;
    [SerializeField] private float seconds = 11.0f;
    // Start is called before the first frame update
    void Awake()
    {
        firstScreen.enabled = true;

        

    }

    private void Start()
    {
        print("ReadingIncarnation");
        if (GameObject.FindGameObjectWithTag("Reincarnation").GetComponent<Reincarnation>().times > 0)
        {
            Destroy(gameObject);
            print("DestroyRan");
            return;
        }
        print("Went pass destroy");

        DontDestroyOnLoad(this.gameObject);
        firstScreen.enabled = false;
        StartCoroutine(StartFirstScreenAfterSeconds(seconds));
        GameObject.FindGameObjectWithTag("Reincarnation").GetComponent<Reincarnation>().times += 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator StartFirstScreenAfterSeconds(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        firstScreen.enabled = true;
        gameObject.SetActive(false);
    }
}
