using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mesh_Agents : MonoBehaviour
{

    [SerializeField] private Transform waypoint1Transform;
    [SerializeField] private Transform waypoint2Transform;
    [SerializeField] private Transform waypoint3Transform;
    [SerializeField] private Transform waypoint4Transform;
    [SerializeField] private Transform waypoint5Transform;

    int index = 1;

    public LinkedList<Transform> waypoints = new LinkedList<Transform>();

    private NavMeshAgent agent;

    private void Start()
    {
        waypoints.AddLast(waypoint1Transform);
        waypoints.AddLast(waypoint2Transform);
        waypoints.AddLast(waypoint3Transform);
        waypoints.AddLast(waypoint4Transform);
        waypoints.AddLast(waypoint5Transform);
        agent.destination = waypoint1Transform.position;

    }

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        
    }


    // Update is called once per frame
    void Update()
    {

        
    }

    private void OnTriggerEnter(Collider other)
    {

               
    }
}
