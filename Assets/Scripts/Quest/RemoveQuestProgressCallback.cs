using UnityEngine;

[CreateAssetMenu(menuName = "Dialogue Callbacks/Remove Quest Progress")]
public class RemoveQuestProgressCallback : DialogueCallback
{
    [SerializeField] private string npcName;

    public override void Invoke()
    {
        GameObject npcObject = GameObject.Find(npcName);
        if (npcObject != null)
        {
            NPC npc = npcObject.GetComponent<NPC>();
            if (npc != null)
            {
                npc.SetQuestProgress(null);
            }
        }
    }
}
