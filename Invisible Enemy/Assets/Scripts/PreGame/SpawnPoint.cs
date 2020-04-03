using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
	public Transform spawnPoint;
	public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player.transform.position = spawnPoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
