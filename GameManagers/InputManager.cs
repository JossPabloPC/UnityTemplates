using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public delegate void MoveEvent(Vector2 value);
    public event MoveEvent CameraRotate;

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
        Vector2 camera = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        CameraRotate(camera);


        if (Input.GetKey(KeyCode.Q))
            OnPlayerUp();
        else if (Input.GetKey(KeyCode.A))
            OnPlayerDown();
    }
}
