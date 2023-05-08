using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueSystem : MonoBehaviour
{
    public static DialogueSystem instance;

    [SerializeField] private TextMeshProUGUI conversantNameText;
    [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField] private GameObject dialogueGameObject;
    [SerializeField] private Animator animator;
    [SerializeField] private Image image;

    private DialogueData currentDialogueData;
    private bool isSkipping = true;

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
        dialogueGameObject.SetActive(false);
    }

    public void ShowDialogue(DialogueData dialogueData)
    {
        currentDialogueData = dialogueData;
        isSkipping = false;
        ShowCurrentDialogue();
        dialogueGameObject.SetActive(true);
    }

    public void ShowCurrentDialogue()
    {
        conversantNameText.text = currentDialogueData.conversantName;
        dialogueText.text = currentDialogueData.dialogueText;

        foreach (DialogueCallback onEnterCallback in currentDialogueData.onEnterCallbacks)
        {
            onEnterCallback?.Invoke();
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K) && !isSkipping)
        {
            foreach (DialogueCallback onExitCallback in currentDialogueData.onExitCallbacks)
            {
                onExitCallback?.Invoke();
            }

            currentDialogueData = currentDialogueData.nextDialogue;
            if (currentDialogueData != null)
            {
                ShowCurrentDialogue();
            }
            else
            {
                dialogueGameObject.SetActive(false);
                isSkipping = true;
            }
        }
    }

    public void UnSkipDialogue()
    {
        isSkipping = false;
    }

    public void PlayAnimation(string animationName)
    {
        if (animator != null && !string.IsNullOrEmpty(animationName))
        {
            isSkipping = true;
            animator.Play(animationName);
        }
    }

    public void SetImage(Sprite sprite)
    {
        if (image != null)
        {
            image.sprite = sprite;
        }
    }
}
