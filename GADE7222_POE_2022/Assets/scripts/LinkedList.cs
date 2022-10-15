using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkedList : MonoBehaviour
{
    Node hea;

    public static LinkedList instance { get; private set; }


    public LinkedList<Transform> waypoints = new LinkedList<Transform>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Awake()
    {
        if(instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
        }
    }

    public Transform GetNth(int index)
    {
        Node node = hea;

        int count = 0;
        while(node != null)
        {
            if(count == index)
            {
                return node.data;
           
            }
            count++;
            node = node.next;
        }

        Debug.Assert(false);
        return null;
    }

    public void push(Transform newData)
    {
        Node new_node = new Node(newData);
        new_node.next = hea;
        waypoints.AddLast(newData);
        hea = new_node;

    }
}
