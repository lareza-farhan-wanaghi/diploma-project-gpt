using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextTypingAnim : MonoBehaviour
{
    const float typingSpeed = 0.001f; // Adjust the speed of the typing animation if desired
    private string fullText;
    private string currentText;
    [SerializeField] TextMeshProUGUI textComponent;
public bool isAnimating;

    public void StartAnim(string text)
    {
        fullText = text;
        currentText = string.Empty;
        textComponent.text = currentText;
        StartCoroutine(TypeText());
    }

    IEnumerator TypeText()
    {
        foreach (char c in fullText)
        {
            currentText += c;
            textComponent.text = currentText;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public bool IsTyping(){
        return fullText.Length != currentText.Length;
    }
}
