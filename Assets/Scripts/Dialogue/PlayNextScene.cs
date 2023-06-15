using UnityEngine;

[CreateAssetMenu(fileName = "New ShowHideGameObject Callback", menuName = "Dialogue Callbacks/Play Next Scene")]
public class PlayNextScene : DialogueCallback
{
    public override void Invoke()
    {
        GameObject.FindObjectOfType<SceneLoader>().LoadScene();
    }
}
