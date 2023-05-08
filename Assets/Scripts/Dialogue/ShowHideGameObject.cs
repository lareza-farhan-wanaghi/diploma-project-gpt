using UnityEngine;

[CreateAssetMenu(fileName = "New ShowHideGameObject Callback", menuName = "Dialogue Callbacks/Show Hide Game Object")]
public class ShowHideGameObject : DialogueCallback
{
    [SerializeField] private string gameObjectName;
    [SerializeField] private bool isActive;

    public override void Invoke()
    {
        GameObject gameObjectToToggle = GameObject.Find(gameObjectName);
        if (gameObjectToToggle != null)
        {
            gameObjectToToggle.transform.GetChild(0).gameObject.SetActive(isActive);
        }
    }
}
