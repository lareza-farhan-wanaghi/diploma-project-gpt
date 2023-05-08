using UnityEngine;
using UnityEngine.UI;

public class AlbumItem : MonoBehaviour
{
    [SerializeField] private Image albumImage;

    public void SetSprite(Sprite sprite)
    {
        albumImage.sprite = sprite;
    }

    public void SetColor(bool isTaken)
    {
        albumImage.color = isTaken ? Color.white : Color.black;
    }

    public void OnClick()
    {
        HighlightedAlbumItem.Instance.ShowHighlight(albumImage.sprite);
    }
}
