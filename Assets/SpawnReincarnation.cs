using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnReincarnation : MonoBehaviour
{
    public GameObject reincarnationObject;
    // Start is called before the first frame update
    void Awake()
    {
        if (!GameObject.FindGameObjectWithTag("Reincarnation"))
        {
            Instantiate(reincarnationObject);
            print("InstantiatedReincarnation");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
