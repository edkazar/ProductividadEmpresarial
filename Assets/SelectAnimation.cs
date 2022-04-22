using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectAnimation : MonoBehaviour
{
    [SerializeField]
    private bool isTriggered;

    [SerializeField]
    private GameObject animHolder1;

    [SerializeField]
    private GameObject animHolder2;

    // Start is called before the first frame update
    void Start()
    {
        animHolder1.SetActive(isTriggered);
        animHolder2.SetActive(!isTriggered);
    }

    // Update is called once per frame
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animHolder1.SetActive(!animHolder1.activeSelf);
            animHolder2.SetActive(!animHolder2.activeSelf);
        }

    }
}
