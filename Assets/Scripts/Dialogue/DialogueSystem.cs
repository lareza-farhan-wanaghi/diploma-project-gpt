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
    [SerializeField] private TextTypingAnim textTypingAnim;

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

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K) && !isSkipping && !textTypingAnim.IsTyping())
        {
            foreach (DialogueCallback onExitCallback in currentDialogueData.onExitCallbacks)
            {
                onExitCallback?.Invoke();
            }

            currentDialogueData = currentDialogueData.nextDialogue;
            if (currentDialogueData != null)
            {
                SetCurrentDialogue();
                ShowDialogueBox();
            }
            else
            {
                dialogueGameObject.SetActive(false);
                isSkipping = true;
                FindObjectOfType<MainCharacter>().SetEnableInputs(true);
            }
        }
    }

    private void ShowDialogueBox(){
        isSkipping = false;
        dialogueGameObject.SetActive(true);
        textTypingAnim.StartAnim(currentDialogueData.dialogueText);
    }

    public void SetDialogue(DialogueData dialogueData)
    {
        FindObjectOfType<MainCharacter>().SetEnableInputs(false);
        currentDialogueData = dialogueData;
        SetCurrentDialogue();
        ShowDialogueBox();
    }

    public void SetCurrentDialogue()
    {
        conversantNameText.text = currentDialogueData.conversantName;
        dialogueText.text = currentDialogueData.dialogueText;

        foreach (DialogueCallback onEnterCallback in currentDialogueData.onEnterCallbacks)
        {
            onEnterCallback?.Invoke();
        }

    }

    public void UnSkipDialogue()
    {
        ShowDialogueBox();
    }

    public void PlayAnimation(string animationName)
    {
        if (animator != null && !string.IsNullOrEmpty(animationName))
        {
            isSkipping = true;
            animator.Play(animationName);
            dialogueGameObject.SetActive(false);
            Debug.Log("Play Anim");
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
