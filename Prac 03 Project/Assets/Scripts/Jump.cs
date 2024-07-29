using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Jump : MonoBehaviour
{
    private PlayerActions actions;
    private InputAction jumpAction;

    void Awake()
    {
        actions = new PlayerActions();
        jumpAction = actions.movement.jump;
    }
    void OnEnable()
    {
        jumpAction.Enable();
    }
    void OnDisable()
    {
        jumpAction.Disable();
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
