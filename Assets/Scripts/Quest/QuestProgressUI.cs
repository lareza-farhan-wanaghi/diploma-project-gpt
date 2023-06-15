using UnityEngine;
using TMPro;

public class QuestProgressUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI titleText;
    [SerializeField] private TextMeshProUGUI objectiveText;

    public void SetText(QuestProgress questProgress)
    {
        titleText.text = questProgress.quest.title;
        string objectiveString = "";
        for (int i = 0; i < questProgress.objectiveProgress.Length; i++)
        {
            if (questProgress.objectiveProgress[i] >= questProgress.quest.objectives[i].quantity)
            {
                objectiveString += "<color=green>";
            }
            objectiveString += "- " + questProgress.quest.objectives[i].description+ " " + questProgress.objectiveProgress[i] + " / " + questProgress.quest.objectives[i].quantity + "\n";
            if (questProgress.objectiveProgress[i] >= questProgress.quest.objectives[i].quantity)
            {
                objectiveString += "</color>";
            }
        }
        objectiveText.text = objectiveString;
    }

    public void DestroySelf()
    {
        Destroy(gameObject);
    }
}
