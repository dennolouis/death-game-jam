using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public Transform target;

    [SerializeField]
    float speed = 1;
    [SerializeField]
    Player player;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Finish").transform;
        player = GameObject.FindGameObjectWithTag("Reaper").GetComponent<Player>();
        transform.LookAt(target);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, 1) * speed * Time.deltaTime);
        CheckIfReachedGoal();
        CheckIfInPlayerRange();
    }

    void CheckIfReachedGoal()
    {
        if(Vector3.Distance(transform.position, target.position) < 2)
        {
            Destroy(gameObject);
        }
    }

    public void CheckIfInPlayerRange()
    {
        if (Vector3.Distance(transform.position, player.gameObject.transform.position) < 1)
        {

            Destroy(gameObject);
        }
    }
}
