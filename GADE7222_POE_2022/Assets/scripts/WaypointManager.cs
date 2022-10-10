using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class WaypointManager : MonoBehaviour
{

    public static WaypointManager instance;

    private void Awake()
    {
        if(instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }


    public Transform GetNextWaypoint(int currentWaypointID, Node node)
    {
        Transform point;
        int way = 1; 
        while(node != null)
        {
            if(way == 1)
            {
                point = node; 
            }    
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
