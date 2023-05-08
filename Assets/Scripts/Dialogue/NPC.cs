using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class NPC : MonoBehaviour
{
    [SerializeField] private string dialogueData;
    [SerializeField] private SpriteRenderer notifyRenderer;
    [SerializeField] private Sprite[] notifySprites;
    private QuestProgress questProgress;
    private NavMeshAgent navAgent;
    private NPCNavigationCallback navigation;

    public string DialogueData
    {
        get { return dialogueData; }
        set { dialogueData = value; }
    }

    private void Awake()
    {
        navAgent = GetComponent<NavMeshAgent>();
        navAgent.updateRotation = false;
        navAgent.updateUpAxis = false;
    }

    private void Start()
    {
        EventSystem.instance.AddEventListener(EventListener);
    }

    private void OnDestroy()
    {
        EventSystem.instance.RemoveEventListener(EventListener);
    }

    public void SetQuestProgress(QuestProgress questProgress)
    {
        if (this.questProgress != null)
        {
            this.questProgress.DestroyQuestProgressUI();
        }
        this.questProgress = questProgress;

        UpdateNotifySprite();
    }

    private void EventListener(IngameEventType eventType, string eventData)
    {
        if (questProgress != null)
        {
            bool isPreviouslyCompleted = questProgress.isCompleted;
            questProgress.UpdateObjectiveProgress(eventType, eventData);
            if (!isPreviouslyCompleted)
            {
                CheckQuestCompletion();
            }
        }
    }

    private void CheckQuestCompletion()
    {
        if (questProgress.isCompleted)
        {
            dialogueData = questProgress.quest.completionDialogue;
            UpdateNotifySprite();
        }
    }

    private void UpdateNotifySprite()
    {
        if (questProgress == null && string.IsNullOrEmpty(dialogueData))
        {
            notifyRenderer.sprite = null;
        }
        else if (questProgress == null && !string.IsNullOrEmpty(dialogueData))
        {
            notifyRenderer.sprite = notifySprites[0];
        }
        else if (questProgress.isCompleted)
        {
            notifyRenderer.sprite = notifySprites[1];
        }
        else
        {
            notifyRenderer.sprite = notifySprites[2];
        }
    }

    public void SetNavigation(NPCNavigationCallback navigation)
    {
        StartCoroutine(SetNavigationCoroutine(navigation));
    }

    private IEnumerator SetNavigationCoroutine(NPCNavigationCallback navigation)
    {
        yield return new WaitForSeconds(0.2f);
        GameObject target = GameObject.Find(navigation.navigationTarget);
        if (target != null)
        {
            navAgent.SetDestination(target.transform.position);
        }
        this.navigation = navigation;
    }

    private void Update()
    {
        if (navigation != null && !navAgent.pathPending && navAgent.remainingDistance < 0.1f)
        {
            DialogueData = navigation.dialogue;
            UpdateNotifySprite();
            navigation = null;
        }
    }
}