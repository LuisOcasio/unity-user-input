using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //initialize functionality for player to Jump
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            Debug.Log("Space bar pressed");
        }    
    }
}
