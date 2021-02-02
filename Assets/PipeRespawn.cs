using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeRespawn : MonoBehaviour
{
    public float Maxtime = 1;
    private float timer = 0;
    public GameObject pipe;
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        //instance the first pipe
        GameObject npipe = Instantiate(pipe);
        npipe.transform.position += transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > Maxtime)
        {
            //create a new instance of pipe after the maxtime
            GameObject npipe = Instantiate(pipe);
            //Respawn the pipe with new Y position, X and Z are the same
            npipe.transform.position += transform.position + new Vector3(0,Random.Range(-height,height),0);
            //Destroy Pipe after new one respawn
            Destroy(npipe,14);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
