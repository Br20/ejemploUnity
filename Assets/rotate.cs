using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(transform.forward);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = transform.position + 0.2f * transform.forward ;
    }
}
