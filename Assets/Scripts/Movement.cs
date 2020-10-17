using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3 distanceX;
    public Vector3 distanceY;
    public Vector3 distanceZ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("d"))
        {
            transform.position += distanceX;
        }
        if(Input.GetKey("a"))
        {
            transform.position -= distanceX;
        }
        if(Input.GetKey("w"))
        {
            transform.position += distanceZ;
        }
        if(Input.GetKey("s"))
        {
            transform.position -= distanceZ;
        }
        if(Input.GetKey("o"))
        {
            transform.position -= distanceY;
        }
        if(Input.GetKey("l"))
        {
            transform.position += distanceY;
        }
    }
}
