using UnityEngine;

[CreateAssetMenu(fileName = "SetNPCDialogueCallback", menuName = "Dialogue Callbacks/Set NPC Dialogue Callback")]
public class SetNPCDialogue : DialogueCallback
{
    public string  dialogueName;
    public string npcName;

    public override void Invoke()
    {
        GameObject npcGO = GameObject.Find(npcName);
        if (npcGO != null)
        {
            NPC npc = npcGO.GetComponent<NPC>();
            if (npc != null)
            {
                npc.DialogueData = dialogueName;
            }
        }
    }
}
