using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject target;

    Vector3 offset;
    
    void Start()
    {
        offset = transform.position;
    }

    void LateUpdate()//poziva se na kraju iscrtavanja kadra
    {
        transform.position = offset + target.transform.position;//offset je pocetni polozaj kamere
    }
}
