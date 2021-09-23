using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour
{
    public GameObject target;
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position;
    }

    // LateUpdate is called once per frame, at the end od the frame
    void LateUpdate()
    {
        transform.position = offset + target.transform.position;
    }
}
