using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public Animator transitionAnimator;

    private bool isTransitioning = false;

    public void LoadScene()
    {
        // Enable the SceneLoader object before starting the coroutine
        gameObject.SetActive(true);

        transitionAnimator.Play("StartTransition");
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }

    public void Load(){
        var nextIndex = (SceneManager.GetActiveScene().buildIndex + 1)% SceneManager.sceneCountInBuildSettings;
        Debug.Log(SceneManager.sceneCount);
        Debug.Log(nextIndex);
        SceneManager.LoadScene(nextIndex);
    }
}
