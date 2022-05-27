using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawn : MonoBehaviour
{
    public GameObject monster;

    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void Spawn()
    {
        Vector3 spawnPoint = new Vector3(0, 0, transform.position.z + 60);
        Instantiate(monster,  spawnPoint, Quaternion.identity);
    }

}
