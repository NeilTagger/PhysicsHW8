using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HangingBoxScript : MonoBehaviour
{
    public Rigidbody2D rb;
    private float thrust = 5.0f;
    public GameObject parachute;
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(transform.right * thrust);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            parachute.SetActive(false);
        }
    }
   
    void Update()
    {
        
    }
}
