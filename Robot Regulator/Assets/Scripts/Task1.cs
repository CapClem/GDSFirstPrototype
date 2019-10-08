using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1 : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            print("dope");
        }
    }

    /*void Randomizer()
    {
        var val = Random.value;

        if (val < 0.5f)
        {
            print("<");
        }
        else if (val > 0.5f)
        {
            print(">");
        }
    }*/
}

