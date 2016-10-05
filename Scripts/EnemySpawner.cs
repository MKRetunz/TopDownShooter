using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {
    private int enemyMax;
    private int enemiesSpawned;

    private float spawnTimer;

    public GameObject enemyBase;

	// Use this for initialization
	void Start () {
        enemyMax = 10;
        enemiesSpawned = 0;
	}
	
	// Update is called once per frame
	void Update () {
	    if (spawnTimer >= 2.0f && enemiesSpawned <= enemyMax)
        {
            SpawnEnemy();

            spawnTimer = 0.0f;
        }

        spawnTimer += Time.deltaTime;
	}

    void SpawnEnemy ()
    {
        GameObject Enemy = (Instantiate(enemyBase, transform.position, transform.rotation)) as GameObject;
    }
}
