using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOverChecker : MonoBehaviour
{
    // Start is called before the first frame update
    bool isTriggered;

    [SerializeField]
    private Animator myAnim1;

    [SerializeField]
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        isTriggered = false;
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
            if (!isTriggered)
            {
                myAnim1.SetTrigger("Active");
                isTriggered = true;
                audioSource.Play();
            }
            else
            {
                myAnim1.SetTrigger("Inactive");
                isTriggered = false;
                audioSource.Stop();
            }
        }
    }
}
