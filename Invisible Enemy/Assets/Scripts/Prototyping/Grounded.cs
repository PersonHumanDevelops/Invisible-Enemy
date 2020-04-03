using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{
	public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.collider.tag == "Ground")
		{
			Player.GetComponent<Movement>().isGrounded = true;
		}
	}
	private void OnCollisionExit2D(Collision2D collision)
	{
		if(collision.collider.tag == "Ground")
		{
			Player.GetComponent<Movement>().isGrounded = false;
		}
	}
}
