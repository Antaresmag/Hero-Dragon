using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elenet : MonoBehaviour
{
    public static Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Menu.destobjt == true)
        {
            rb.gravityScale = 1f;
            Menu.destobjt = false;
        }
        
        
    }
}
