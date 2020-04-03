using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	public float speed;
	public float jumpHeight;
	public bool isGrounded = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
	
	
    // Update is called once per frame
    void Update()
    {
		Jump();
		transform.position += new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);
		
    }
	
	void Jump()
	{
		if(Input.GetButtonDown("Jump") && isGrounded == true)
		{
			gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpHeight), ForceMode2D.Impulse);
		}
		
	}
	
	 
}
