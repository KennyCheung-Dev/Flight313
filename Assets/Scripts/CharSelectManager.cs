using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharSelectManager : MonoBehaviour
{
    [SerializeField] private Animator left, mid, right;
    [SerializeField] private Image panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (panel.color.a > 0.0f)
        {
            panel.color = new Color(panel.color.r, panel.color.g, panel.color.b, panel.color.a - 0.01f);
        }
    }

    public void Animate(int i)
    {
        switch (i)
        {
            case 0:
                left.SetBool("white", true);
                mid.SetBool("white", false);
                right.SetBool("white", false);
                break;
            case 1:
                mid.SetBool("white", true);
                left.SetBool("white", false);
                right.SetBool("white", false);
                break;
            case 2:
                right.SetBool("white", true);
                left.SetBool("white", false);
                mid.SetBool("white", false);
                break;
        }
    }
}
