using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonActions : MonoBehaviour
{
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

}
