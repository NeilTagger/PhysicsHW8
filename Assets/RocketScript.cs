using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketScript : MonoBehaviour
{
    public GameObject target;
    public GameObject myself;
    public Rigidbody2D rb;
    private float thrust = 400;
    
    void Start()
    {
        rb.AddForce(transform.right * thrust);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Target")
        {
            target.SetActive(false);
            myself.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
