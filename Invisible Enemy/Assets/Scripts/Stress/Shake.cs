using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    public bool isAwake = false;
    public float speed =1;
    public float wantedSpeed;
    public float time;
    public float period =10;
 

    // Start is called before the first frame update
    void Start()
    {
        isAwake = false;
        wantedSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        time= time+Time.deltaTime;
             if (isAwake == true) ;
        {
            speed = wantedSpeed;
            transform.Rotate(0, 0, speed * Mathf.Sin(period*(time - 0)));
                    }
        if (isAwake == false) ;
        {
            speed = 0;
            transform.Rotate(0, 0, 0) ;
        }
    }
   }
