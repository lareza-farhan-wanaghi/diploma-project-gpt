using UnityEngine;
using TMPro;

public class AnimatedText : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private TextMeshProUGUI text;

    public static AnimatedText instance;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        gameObject.SetActive(false);
    }

    public void ShowText(string message)
    {
        gameObject.SetActive(true);
        text.text = message;
        anim.Play("Show");
    }

    public void HideText()
    {
        gameObject.SetActive(false);
    }
}
