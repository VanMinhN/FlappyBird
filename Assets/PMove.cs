using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PMove : MonoBehaviour { 
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move the pipe to the left
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
