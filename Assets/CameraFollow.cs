using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] GameObject target;
    void Update()
    {
        transform.position = target.transform.position + new Vector3(10, 10, -10);
    }
}
