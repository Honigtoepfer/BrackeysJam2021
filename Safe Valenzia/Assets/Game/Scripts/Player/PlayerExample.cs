using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExample : MonoBehaviour
{
    
    private MainInput mainUnput;
    
    void Awake()
    {
        mainUnput = new MainInput();
        mainUnput.Player.interaction.started += ContextMenu => interaction();
    }

    private void interaction()
    {

    }

    void FixedUpdate()
    {
        Vector2 dir = mainUnput.Player.move.ReadValue<Vector2>();
    }

    void OnEnable()
    {
        mainUnput.Enable();
    }

    void OnDisable()
    {
        mainUnput.Disable();
    }

}
