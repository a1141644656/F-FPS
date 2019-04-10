using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class up_down : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        float height = transform.localPosition.y;
        Debug.Log(height);
        if(height > -2.6f)
        {
            height = height - 0.1f;
            Debug.Log(height + " if");
        }
        else
        {
            height = 2.5f;
            Debug.Log(height + " else");
        }
        transform.localPosition.Set(transform.localPosition.x, height, transform.localPosition.z);
        */

        if (Input.GetKeyDown("f"))
        {
            if (transform.position.y > 0)
                transform.position = new Vector3(transform.position.x, -2.5f, transform.position.z);
            else
                transform.position = new Vector3(transform.position.x, 2.5f, transform.position.z);
        }
    }
}
