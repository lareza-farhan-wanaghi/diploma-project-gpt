using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainmenuManager : MonoBehaviour
{
    [SerializeField] PrologueSystem prologueSystem;
 public void StartGame(){
    prologueSystem.ShowPrologue();
    AudioManager.instance.PlayAudioSource(0);
 }
}
