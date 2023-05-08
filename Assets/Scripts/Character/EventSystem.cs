using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public enum IngameEventType
{
    TalkingWithNPC,
    TakingAPhoto,
    AddingAPhoto
}

public class EventData
{
    public IngameEventType eventType;
    public string eventData;

    public EventData(IngameEventType eventType, string eventData)
    {
        this.eventType = eventType;
        this.eventData = eventData;
    }
}

public class EventSystem : MonoBehaviour
{
    public static EventSystem instance;
    public TextMeshProUGUI eventText;
    private EventData currentEventData;
    private Action<IngameEventType, string> eventAction;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void TriggerEvent(EventData eventData)
    {
        currentEventData = eventData;
        eventText.text = "Press K to " + currentEventData.eventType.ToString();
        eventText.gameObject.SetActive(true);
    }

    public void ClearEventData()
    {
        currentEventData = null;
    }

    public void DisableEventTextUI()
    {
        eventText.gameObject.SetActive(false);
    }

    public void AddEventListener(Action<IngameEventType, string> listener)
    {
        eventAction += listener;
    }

    public void RemoveEventListener(Action<IngameEventType, string> listener)
    {
        eventAction -= listener;
    }

    public void ProceedEvent(EventData eventData)
    {
        // Execute additional things based on the enum in the event data
        switch (eventData.eventType)
        {
            case IngameEventType.TalkingWithNPC:
                NPC npc = GameObject.Find(eventData.eventData).GetComponent<NPC>();
                DialogueData dialogueData = Resources.Load<DialogueData>("Dialogues/" + npc.DialogueData);
                if (dialogueData != null)
                {
                    DialogueSystem.instance.ShowDialogue(dialogueData);
                    npc.DialogueData = null;
                }
                break;

            case IngameEventType.TakingAPhoto:
                SliderMiniGame sliderMiniGame = FindObjectOfType<SliderMiniGame>();
                if (sliderMiniGame != null)
                {
                    sliderMiniGame.StartMiniGame(eventData.eventData);
                }
                break;
            case IngameEventType.AddingAPhoto:
                PhotoStorage.Instance.AddPhoto(eventData.eventData);
                break;
            default:
                break;
        }

        // Invoke the event action with the event data variables as the arguments
        eventAction?.Invoke(eventData.eventType, eventData.eventData);
    }

    private void Update()
    {
        if (currentEventData != null && Input.GetKeyDown(KeyCode.K))
        {
            ProceedEvent(currentEventData);
            ClearEventData();
            DisableEventTextUI();
        }
    }
}
