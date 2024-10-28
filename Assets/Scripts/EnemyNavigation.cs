using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyNavigation : MonoBehaviour
{
    public NavMeshAgent agent;

    public Temporizador Arranque;
    public Transform player;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform;

       

    }


    void Update()
    {
        if (Arranque.TiempoActivo == true)
        {
            SetDestination(player.position);
        }
    }

    public void SetDestination(Vector3 newdestination)
    {
        agent.destination = newdestination;

    }

}
