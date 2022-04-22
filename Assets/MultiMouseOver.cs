using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiMouseOver : MonoBehaviour
{
    // Start is called before the first frame update
    bool isTriggered1;
    bool isTriggered2;

    [SerializeField]
    private GameObject myObject1;

    [SerializeField]
    private GameObject myObject2;

    [SerializeField]
    private Animator myAnim1;

    [SerializeField]
    private AudioSource audioSource1;

    [SerializeField]
    private Animator myAnim2;

    [SerializeField]
    private AudioSource audioSource2;

    // Start is called before the first frame update
    void Start()
    {
        isTriggered1 = false;
        isTriggered2 = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseOver()
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
        if (Input.GetMouseButtonDown(0))
        {
            if (myObject1.activeSelf)
            {
                if (!isTriggered1)
                {
                    myAnim1.SetTrigger("Active");
                    isTriggered1 = true;
                    audioSource1.Play();
                }
                else
                {
                    myAnim1.SetTrigger("Inactive");
                    isTriggered1 = false;
                    audioSource1.Stop();
                }
            }

            else
            {
                if (!isTriggered2)
                {
                    myAnim2.SetTrigger("Active");
                    isTriggered2 = true;
                    audioSource2.Play();
                }
                else
                {
                    myAnim2.SetTrigger("Inactive");
                    isTriggered2 = false;
                    audioSource2.Stop();
                }
            }
        }
    }
}
