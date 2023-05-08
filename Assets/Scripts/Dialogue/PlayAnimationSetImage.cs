using UnityEngine;

[CreateAssetMenu(fileName = "PlayAnimationSetImage", menuName = "Dialogue Callbacks/PlayAnimationSetImage")]
public class PlayAnimationSetImage : DialogueCallback
{
    [SerializeField] private string animationName;
    [SerializeField] private Sprite image;

    public override void Invoke()
    {
        DialogueSystem.instance.PlayAnimation(animationName);
        DialogueSystem.instance.SetImage(image);
    }
}
