using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Robot : MonoBehaviour
{
    public GameObject idlePos;
    public int robotHealth;

    //Name our nave mesh
    NavMeshAgent myNav;

    //Name the diffrent states of our robot & set start
    public enum state { Idle, Task1, Task2, Task3, Malfunction, Destroyed };
    public state myState = state.Idle;

    //set starting position for our robot tasks/activities
    public Transform task1Position;
    public Transform task2Position;
    public Transform task3Position;
    
    // Start is called before the first frame update
    void Start()
    {
        //call the nav mesh.
        myNav = this.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {

        // Create switchboard to hold action for our robot
        switch (myState)
        {
            case state.Idle:
                break;

            case state.Task1:
                myNav.SetDestination(task1Position.transform.position);
                break;

            case state.Task2:
                myNav.SetDestination(task2Position.transform.position);
                break;

            case state.Task3:
                myNav.SetDestination(task3Position.transform.position);
                break;

            case state.Malfunction:
                break;

            case state.Destroyed:
                break;
        }
       // if (input.get) ;
    }
        //Add state machine states 
        //idle
        //task1 (substates ie travelling to location, completing task, returning to idlePos)
        //task2 ""
        //task3 ""
        //malfunction
        //destroyed
        
        //if state = idle
        //return to robot idle area

        //if 

}
