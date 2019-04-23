using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemy : MonoBehaviour
{
	private int spawn_timer;
	public int spawn_time;
    // Start is called before the first frame update
    void Start()
    {
    	spawn_timer = 0;
        spawn_time = 50;
    }

    // Update is called once per frame
    void Update()
    {
    	spawn_timer++;
    	if(spawn_timer == spawn_time)
    	{
    		//spawn a new enemy
    		// enemy has scripts: EnemyMovement, EnemyHealth, EnemyAttack
    		spawn_timer = 0;
    	}
    }
}
