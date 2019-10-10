using UnityEngine;

public class Task2 : MonoBehaviour
{
    public GameObject Taskitem;
    public GameObject Hold;
    void OnTriggerEnter(Collider col)
    {
        switch (col.tag)
        {
            case "Task2":
                Start();
                break;
        }
    }

    void Start()
    {
        print("2");
    }
}
