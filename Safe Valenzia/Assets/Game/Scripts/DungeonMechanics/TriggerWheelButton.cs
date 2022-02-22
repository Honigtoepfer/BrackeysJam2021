using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWheelButton : MonoBehaviour, IInteractable
{
    
    [SerializeField] private WheelRotate wheelRotate;

    public void Interact()
    {
        wheelRotate.TriggerWheel();
    }

    public void Enter()
    {
        
    }

    public void Exit()
    {
        
    }
}
