using UnityEngine;

[CreateAssetMenu(menuName = "Dialogue System/Dialogue Data")]
public class DialogueData : ScriptableObject
{
    public string conversantName;
    public string dialogueText;
    public DialogueData nextDialogue;
    public DialogueCallback[] onEnterCallbacks;
    public DialogueCallback[] onExitCallbacks;
}
