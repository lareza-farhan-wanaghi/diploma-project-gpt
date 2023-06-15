using UnityEngine;
using TMPro;
public class QuestProgress
{
    public Quest quest;
    public int[] objectiveProgress;
    private QuestProgressUI questProgressUI;
    public bool isCompleted;

    public void Initialize(Quest quest)
    {
        this.quest = quest;
        objectiveProgress = new int[quest.objectives.Length];
        GameObject questProgressUIGO = GameObject.Instantiate(Resources.Load<GameObject>("Prefabs/QuestProgressUI"), GameObject.Find("QuestProgressUIContainer").transform);
        questProgressUI = questProgressUIGO.GetComponent<QuestProgressUI>();
        questProgressUI.SetText(this);
        AnimatedText.instance.ShowText("Misi Baru Ditambahkan!"); // added line to show animated text
        AudioManager.instance.PlayAudioSource(3);
    }

    public void UpdateObjectiveProgress(IngameEventType eventType, string target)
    {
        for (int i = 0; i < quest.objectives.Length; i++)
        {
            if (quest.objectives[i].eventType == eventType && quest.objectives[i].target == target)
            {
                objectiveProgress[i]++;
            }
        }

        isCompleted = true;
        for (int i = 0; i < objectiveProgress.Length; i++)
        {
            if (objectiveProgress[i] < quest.objectives[i].quantity)
            {
                isCompleted = false;
                break;
            }
        }

        questProgressUI.SetText(this);
    }

    public void DestroyQuestProgressUI()
    {
        questProgressUI.DestroySelf();
        AnimatedText.instance.ShowText("Misi Selesai!"); // added line to show animated text
        AudioManager.instance.PlayAudioSource(2);
    }
}
