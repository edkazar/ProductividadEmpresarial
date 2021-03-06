using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewerMovement : MonoBehaviour
{
    [SerializeField] Transform pos;
    float speed = 2f;
    float angle = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {

    }

    void LateUpdate()
    {
        float horAxis = Input.GetAxis("Horizontal");
        float verAxis = Input.GetAxis("Vertical");

        pos.position += transform.forward * Time.deltaTime * verAxis * speed;
        pos.RotateAround(transform.position, Vector3.up, angle * horAxis * Time.deltaTime);
    }
}
