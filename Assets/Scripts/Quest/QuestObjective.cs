using UnityEngine;

[CreateAssetMenu(fileName = "NewQuestObjective", menuName = "Quests/Objective")]
public class QuestObjective : ScriptableObject
{
    public IngameEventType eventType;
    public string target;
    public int quantity;
}
