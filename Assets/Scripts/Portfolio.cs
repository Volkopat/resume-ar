using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class Portfolio : MonoBehaviour{
    public VirtualButtonBehaviour Vb;
    void Start()
    {
        Vb.RegisterOnButtonPressed(OnButtonPressed);
        Vb.RegisterOnButtonReleased(OnButtonReleased);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Btn Pressed");
        Application.OpenURL("http://www.sarthakagarwal.dev/");
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Btn Released");
    }
}