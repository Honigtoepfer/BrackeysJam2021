using UnityEngine;

public class NPC : MonoBehaviour, IInteractable
{
    [SerializeField]
    DialogueConversation conversation;

    void Start()
    {
        
    }

    public void Interact()
    {
        print("npc interact()");
    }

    public void Enter()
    {
        print("npc enter()");
    }

    public void Exit()
    {
        print("npc exit()");
    }
}
