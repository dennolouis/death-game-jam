using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public Transform target;

    [SerializeField]
    float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Finish").transform;
        transform.LookAt(target);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, 1) * speed * Time.deltaTime);
        CheckIfReachedGoal();
    }

    void CheckIfReachedGoal()
    {
        if(Vector3.Distance(transform.position, target.position) < 2)
        {
            Destroy(gameObject);
        }
    }
}
