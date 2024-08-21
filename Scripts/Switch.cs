using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.X))
            this.GetComponent<Light>().enabled = true;
        if (Input.GetKey(KeyCode.Y))
            this.GetComponent<Light>().enabled = false;
    }
}
