using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1 : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        switch (col.tag)
        {
            case "Task1":
            Start();
            break;
        }
    }

    void Start()
    {
        print("1");
    }
}

