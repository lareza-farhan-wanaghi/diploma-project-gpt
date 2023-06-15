using UnityEngine;

[CreateAssetMenu(fileName = "PlaySFXAfterDialogue", menuName = "Dialogue Callbacks/Play SFX After Dialogue")]
public class PlaySFXAfterDialogue : DialogueCallback
{
    public int index;
    public override void Invoke()
    {
        AudioManager.instance.PlayAudioSource(index);
    }
}
