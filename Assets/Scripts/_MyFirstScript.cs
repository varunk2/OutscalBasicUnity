using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    private void Awake()
    {
        //Debug.Log("MyFirstScript Awake Function.");
    }
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("MyFirstScript Start Function");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("MyFirstScript Update Function");

        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("Update Input F pressed");
        }

        if (Input.GetKey(KeyCode.F))
        {
            Debug.Log("Update Input F");
        }

        if (Input.GetKeyUp(KeyCode.F))
        {
            Debug.Log("Update Input F released");
        }
    }

    private void LateUpdate()
    {
        
    }

    private void OnDestroy()
    {
        
    }
}
