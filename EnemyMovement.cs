using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        Enemy enemy = GetComponent<Enemy>(); 
        agent.SetDestination(enemy.menager.ourBase.position);
    }

    // Update is called once per frame
    void Update()
    {
       // GetComponent<Transform>().Translate(0, 0, speed * Time.deltaTime);
    }
}
