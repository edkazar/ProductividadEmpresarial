using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    [SerializeField] Transform camera;
    [SerializeField] Transform myPos;
    float speed = 2f;
    float angle = 20f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.forward = new Vector3(camera.forward.x, transform.forward.y, camera.forward.z);
    }
}
