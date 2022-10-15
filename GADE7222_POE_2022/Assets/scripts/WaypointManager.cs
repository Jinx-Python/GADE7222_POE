using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.AI;

public class WaypointManager : MonoBehaviour
{

    public static WaypointManager instance;
    public NavMeshAgent agent;

    [SerializeField] private Transform waypoint1Transform;
    [SerializeField] private Transform waypoint2Transform;
    [SerializeField] private Transform waypoint3Transform;
    [SerializeField] private Transform waypoint4Transform;
    [SerializeField] private Transform waypoint5Transform;
    public LinkedList<Transform> waypoints = new LinkedList<Transform>();
    private void Awake()
    {
        if(instance == null)
            instance = this;
        else
            Destroy(gameObject);
        agent = GetComponent<NavMeshAgent>();
    }

    public object this[int index]
    {
        get { return this; }
        
    }

    private void Start()
    {
        waypoints.AddLast(waypoint1Transform);
        waypoints.AddLast(waypoint2Transform);
        waypoints.AddLast(waypoint3Transform);
        waypoints.AddLast(waypoint4Transform);
        waypoints.AddLast(waypoint5Transform);

        LinkedList.instance.push(waypoint1Transform);
        LinkedList.instance.push(waypoint2Transform);

        agent.destination = LinkedList.instance.

    }

    Node hea;

    private int count;


    public object GetNextWaypoint(int currentWaypointID)
    {

        LinkedListNode<Transform> node = waypoints.First;

        agent.destination = node.Value.position;

        return node;
    
    }

    // Update is called once per frame
    void Update()
    {
        //LinkedListNode<Transform> node = waypoints.First;

        //agent.destination = node.Value.position;
        //waypoints.RemoveFirst();
    }

    /*private void OnTriggerEnter(Collider other)
    {
        LinkedListNode<Transform> node = waypoints.First;

        agent.destination = node.Value.position;
        waypoints.AddLast((Transform)node.Value);
    }*/

    public Transform GetNth(int index)
    {
        Node node = hea;

        int count = 0;
        while (node != null)
        {
            if (count == index)
            {
                return node.data;

            }
            count++;
            node = node.next;
        }
        return null;
    }
}
