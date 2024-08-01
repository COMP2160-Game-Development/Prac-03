using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Jump : MonoBehaviour
{
    PlayerActions playerActions;
    InputAction jumpAction;

    void Awake()
    {
        playerActions = new PlayerActions();
        jumpAction = playerActions.Movement.Jump;
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
