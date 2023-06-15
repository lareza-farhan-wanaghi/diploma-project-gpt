using UnityEngine;
using UnityEngine.UI;

public class AlbumItem : MonoBehaviour
{
    [SerializeField] private Image albumImage;
    bool isTaken;

    public void SetSprite(Sprite sprite, bool _isTaken)
    {
        albumImage.sprite = sprite;
        isTaken =_isTaken;
        SetColor(isTaken);
    }

    public void SetColor(bool isTaken)
    {
        albumImage.color = isTaken ? Color.white : Color.black;
    }

    public void OnClick()
    {
        if (isTaken)
        {
            HighlightedAlbumItem.Instance.ShowHighlight(albumImage.sprite);
        }
    }
}
