using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Transform data;
    public Node next;


    public Node(Transform n)
    {
        data = n;
        next = null;
    }   
}
