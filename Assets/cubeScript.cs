using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeScript : MonoBehaviour
{
    public float rotationSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.GetComponent<Transform>().Rotate(0, rotationSpeed, 0);
    }

    //public void Rotate1()
    //{
    //    this.GetComponent<Transform>().Rotate(0, rotationSpeed, 0);
    //}

    //public void Rotate2()
    //{
    //    this.GetComponent<Transform>().Rotate(0, -rotationSpeed, 0);
    //}
}
