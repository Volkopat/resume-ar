using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class Resume : MonoBehaviour{
    public VirtualButtonBehaviour Vb;
    void Start()
    {
        Vb.RegisterOnButtonPressed(OnButtonPressed);
        Vb.RegisterOnButtonReleased(OnButtonReleased);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
            SceneManager.LoadScene("Resume");
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Btn Released");
    }
}