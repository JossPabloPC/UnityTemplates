using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public delegate void OnStart();
    public event OnStart OnPlayerUp;
    public event OnStart OnPlayerDown;

    public static InputManager Instance
    {
        get;
        private set;
    }

    public void Awake()
    {
        Instance = this;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
            OnPlayerUp();
        else if (Input.GetKey(KeyCode.A))
            OnPlayerDown();
    }
}
