using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawn : MonoBehaviour
{
    public GameObject monster;

    [SerializeField] float spawndelay = 10;

    

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
        GameObject enemy = Instantiate(monster,  spawnPoint, Quaternion.identity);

        transform.Rotate(new Vector3(0, 0, Random.Range(20, 270)));

        Invoke("Spawn", spawndelay);
    }

}
