using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionResponse : MonoBehaviour
{
    public GameObject player;    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject == player)
        {
            Debug.Log("collision detected");
            this.GetComponent<Rigidbody>().AddForce(0,1000,0);
        }
    }
}
