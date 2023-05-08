using UnityEngine;

[CreateAssetMenu(fileName = "NewQuest", menuName = "Quests/Quest")]
public class Quest : ScriptableObject
{
    public string title;
    public string npcName;
    public string completionDialogue;
    public QuestObjective[] objectives;
}
