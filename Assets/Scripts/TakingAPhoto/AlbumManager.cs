using System.Collections.Generic;
using UnityEngine;

public class AlbumManager : MonoBehaviour
{
    [SerializeField] private GameObject albumItemPrefab;
    [SerializeField] private Transform albumItemList;
    [SerializeField] private GameObject albumGameObject;

    // void Start()
    // {
    //     HideAlbum();
    // }

    public void ShowAlbum()
    {
        AudioManager.instance.PlayAudioSource(0);
        DestroyAllAlbumItems();

        foreach (KeyValuePair<string, bool> photo in PhotoStorage.Instance.GetTakenPhotos())
        {
            GameObject albumItemObject = Instantiate(albumItemPrefab, albumItemList);
            AlbumItem albumItem = albumItemObject.GetComponent<AlbumItem>();
            Sprite photoSprite = Resources.Load<Sprite>("Photos/" + photo.Key);
            albumItem.SetSprite(photoSprite,photo.Value);
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
        AudioManager.instance.PlayAudioSource(0);
        albumGameObject.SetActive(false);
    }
}
