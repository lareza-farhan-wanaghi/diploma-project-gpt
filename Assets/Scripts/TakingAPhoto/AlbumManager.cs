using System.Collections.Generic;
using UnityEngine;

public class AlbumManager : MonoBehaviour
{
    [SerializeField] private GameObject albumItemPrefab;
    [SerializeField] private Transform albumItemList;
    [SerializeField] private GameObject albumGameObject;

    void Start()
    {
        HideAlbum();
    }

    public void ShowAlbum()
    {
        DestroyAllAlbumItems();

        foreach (KeyValuePair<string, bool> photo in PhotoStorage.Instance.GetTakenPhotos())
        {
            GameObject albumItemObject = Instantiate(albumItemPrefab, albumItemList);
            AlbumItem albumItem = albumItemObject.GetComponent<AlbumItem>();
            Sprite photoSprite = Resources.Load<Sprite>("Photos/" + photo.Key);
            albumItem.SetSprite(photoSprite);
            albumItem.SetColor(photo.Value);
        }
        albumGameObject.SetActive(true);
    }

    private void DestroyAllAlbumItems()
    {
        foreach (Transform child in albumItemList)
        {
            Destroy(child.gameObject);
        }
    }

    public void HideAlbum()
    {
        albumGameObject.SetActive(false);
    }
}
