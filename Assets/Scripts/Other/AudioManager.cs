using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance {get;private set;}

    [SerializeField]  AudioSource[] audioSource;

    void Awake(){
        if (instance == null) {
            instance = this;
        } else if (instance != this){
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }

    void Start(){
        foreach(Button b in FindObjectsOfType<Button>()){
            b.onClick.AddListener(()=>PlayAudioSource(0));
        }
    }

    public void PlayAudioSource(int index){
        audioSource[index].Play();
    }

    public void StopAudioSource(int index){
        audioSource[index].Stop();
    }
}
