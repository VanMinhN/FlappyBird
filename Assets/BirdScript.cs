using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
	public GameManager gameManager;

    public float velocity = 1;
    private Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>(); //give access to Rigid components;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //left click
        {
            //jump
            rigid.velocity = Vector2.up * velocity;
        }
    }
	
	private void OnCollisionEnter2D(Collision2D collision)
	{
		gameManager.GameOver();
	
	}
	
}
