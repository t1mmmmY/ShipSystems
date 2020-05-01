using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] float speed = 10f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }
}
