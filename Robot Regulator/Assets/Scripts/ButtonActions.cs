using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonActions : MonoBehaviour
{
    //target the robot for task b
    public GameObject robot;
    public GameObject ClipBoard;
    // float for failure chance
    public float failureRate;
    string buttonName;


    // Start is called before the first frame update
    void Start()
    {
        buttonName = this.gameObject.name;
    }

    // Update is called once per frame
    void Update()
    {
        //Exit current sceen on button down
        if (Input.GetKeyDown(KeyCode.Escape) == true)
        {
            ExitKeySceneChange();
        }   
    }

    //what happens when we press escape
    public void ExitKeySceneChange()

    {
        //exit or call the buttons scene name
        if (SceneManager.GetActiveScene().name == "Main Menu")
            {
                Application.Quit();
            }
            else
            {
            SceneManager.LoadScene("Main Menu", LoadSceneMode.Single);
            }
    }

    public void ChangeScene()
    {
        
        //exit or call the buttons scene name
        if (buttonName == "Exit")
        {
            Application.Quit();
        }
        else
        {
            SceneManager.LoadScene(buttonName, LoadSceneMode.Single);
        }
    }

    //create a function for each task 1,2,3. Let the clipboard know to go down and tell the robot to switch state.
    public void StartTask1()
    {
        ClipBoard.GetComponent<MoveClipBoard>().OpinClipBoard();
        //add failure rate for malfunction
        if (failureRate <= Random.Range(0, 100))
        {
            robot.GetComponent<Robot>().myState = Robot.state.Task1;
            //add debug message for testing both options
            Debug.Log("The robot is starting task 1");
        }
        else
        {
            robot.GetComponent<Robot>().myState = Robot.state.Malfunction;
            Debug.Log("The robot is malfunctioning");
        }
        
    }

    public void StartTask2()
    {
        ClipBoard.GetComponent<MoveClipBoard>().OpinClipBoard();
        if (failureRate <= Random.Range(0, 100))
        {
            robot.GetComponent<Robot>().myState = Robot.state.Task2;
            Debug.Log("The robot is starting task 2");
        }
        else
        {
            robot.GetComponent<Robot>().myState = Robot.state.Malfunction;
            Debug.Log("The robot is malfunctioning");
        }
    }

    public void StartTask3()
    {
        ClipBoard.GetComponent<MoveClipBoard>().OpinClipBoard();
        if (failureRate <= Random.Range(0, 100))
        {
            robot.GetComponent<Robot>().myState = Robot.state.Task3; 
            Debug.Log("The robot is starting task 3");
        }
        else
        {
            robot.GetComponent<Robot>().myState = Robot.state.Malfunction;
            Debug.Log("The robot is malfunctioning");
        }
    }
}
