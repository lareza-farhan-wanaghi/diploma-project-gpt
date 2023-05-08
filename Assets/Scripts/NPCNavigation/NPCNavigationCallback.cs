using UnityEngine;
[CreateAssetMenu(fileName = "New Navigation Callback", menuName = "Dialogue Callbacks/NPCNavigation Callback")]
public class NPCNavigationCallback : DialogueCallback
{
    public string npcName;
    public string navigationTarget;
    public string dialogue;

    public override void Invoke()
    {
        GameObject npcObject = GameObject.Find(npcName);
        if (npcObject != null)
        {
            NPC npc = npcObject.GetComponent<NPC>();
            if (npc != null)
            {
                npc.SetNavigation(this);
            }
        }
    }
}
