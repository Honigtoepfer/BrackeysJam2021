using UnityEngine;

public class Player : MonoBehaviour
{
    MainInput mainInput;
    MovementController controller;

    [SerializeField]
    float speed;
    
    void Awake()
    {
        mainInput = new MainInput();
        controller = new MovementController(this.gameObject, speed, mainInput);

        mainInput.Player.interaction.started += ContextMenu => Interaction();
    }

    void OnEnable()
    {
        mainInput.Enable();
    }

    void OnDisable()
    {
        mainInput.Disable();
    }

    void Interaction()
    {
        print("Interaction");
    }

    void Update()
    {
        controller.Process();
    }
}
