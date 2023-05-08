using RotaryHeart.Lib.SerializableDictionary;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PhotoStorage : MonoBehaviour
{
    [SerializeField] private PhotoDictionary takenPhotos = new PhotoDictionary();

    public static PhotoStorage Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddPhoto(string photoName)
    {
        takenPhotos[photoName] = true;
    }

    public bool HasPhoto(string photoName)
    {
        return takenPhotos.ContainsKey(photoName) && takenPhotos[photoName];
    }

    public Dictionary<string, bool> GetTakenPhotos()
    {
        return new Dictionary<string, bool>(takenPhotos);
    }
}

[System.Serializable]
public class PhotoDictionary : SerializableDictionaryBase<string, bool> { }
