using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera cameraBehind;
    public Camera cameraDriver;
    public KeyCode switchKey;

    private bool isDriverView = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(switchKey))
        {
            cameraBehind.enabled = !cameraBehind.enabled;
            cameraDriver.enabled = !cameraDriver.enabled;
        }
        
    }
}
