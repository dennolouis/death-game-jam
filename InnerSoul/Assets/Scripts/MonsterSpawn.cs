using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawn : MonoBehaviour
{
    public GameObject monster;
    public GameObject screen;

    [SerializeField] float spawndelay = 10;
    public Transform[] spawnPoints;

    

    // Start is called before the first frame update
    void Start()
    {
        Invoke("RemoveScreen", 10);
        Spawn();
       
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(new Vector3(0, Random.Range(20, 270), 0) );
    }


    public void Spawn()
    {
        Vector3 spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)].position;
        GameObject enemy = Instantiate(monster,  spawnPoint, Quaternion.identity);

        Invoke("Spawn", spawndelay);
    }

    public void RemoveScreen()
    {
        screen.SetActive(false);
    }

}
