using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task3 : MonoBehaviour
{
    public GameObject Taskitem;
    public GameObject Hold;
    void OnTriggerEnter(Collider col)
    {
        switch (col.tag)
        {
            case "Task3":
                Start();
                break;
        }
    }

    void Start()
    {
        print("3");
    }
}
