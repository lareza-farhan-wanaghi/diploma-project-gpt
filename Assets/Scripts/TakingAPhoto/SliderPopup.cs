using UnityEngine;
using UnityEngine.UI;

public class SliderPopup : MonoBehaviour
{
    public Image image;
    public Animator animator;
    public GameObject popupGameobject;

    private static SliderPopup instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        popupGameobject.SetActive(false);

    }

    public static SliderPopup Instance
    {
        get { return instance; }
    }

    public void Show(Sprite sprite)
    {
        image.sprite = sprite;
        popupGameobject.SetActive(true);
        animator.Play("Show");
        Debug.Log("show pop up");
    }

    public void Hide()
    {
        popupGameobject.SetActive(false);
    }

    public void CameraShutterSound(){
        AudioManager.instance.PlayAudioSource(1);
    }
}
