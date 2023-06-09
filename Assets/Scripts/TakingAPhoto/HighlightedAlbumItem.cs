using UnityEngine;
using UnityEngine.UI;

public class HighlightedAlbumItem : MonoBehaviour
{
    private static HighlightedAlbumItem instance;
    public static HighlightedAlbumItem Instance { get { return instance; } }

    [SerializeField] private Image image;
    [SerializeField] private GameObject container;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
        // HideHighlight();
    }

    public void ShowHighlight(Sprite sprite)
    {
        AudioManager.instance.PlayAudioSource(0);
        container.SetActive(true);
        image.sprite = sprite;
    }

    public void HideHighlight()
    {
        AudioManager.instance.PlayAudioSource(0);
        container.SetActive(false);
    }
}
