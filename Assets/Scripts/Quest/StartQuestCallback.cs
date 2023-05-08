using UnityEngine;

[CreateAssetMenu(fileName = "NewStartQuestCallback", menuName = "Dialogue Callbacks/Start Quest Callback")]
public class StartQuestCallback : DialogueCallback
{
    public Quest quest;

    public override void Invoke()
    {
        // Create a new QuestProgress object with the new statement, 
        // then trigger the Initialize method of the created object with the quest variable as the argument.
        QuestProgress newQuestProgress = new QuestProgress();
        newQuestProgress.Initialize(quest);

        // Find a game object with the name of the npcName variable in the quest variable. 
        // Then get the NPC component from that game object and invoke the SetQuestProgress of the NPC component with the prev QuestProgress object as the argument
        GameObject npcGO = GameObject.Find(quest.npcName);
        if (npcGO != null)
        {
            NPC npc = npcGO.GetComponent<NPC>();
            if (npc != null)
            {
                npc.SetQuestProgress(newQuestProgress);
            }
        }
    }
}
