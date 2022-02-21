using UnityEngine;

[CreateAssetMenu(fileName = "Dialogue Conversation")]
public class DialogueConversation : ScriptableObject
{
    [SerializeField]
    new string name;

    [TextArea(3, 10)]
    public string[] sentences;
}
