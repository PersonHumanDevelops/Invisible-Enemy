using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    public Animator anim;
    void Update()
    {
        
    }
	void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.collider.tag == "Player")
		{
			anim.SetBool("Shake?", true);
		}
	}
	
}
