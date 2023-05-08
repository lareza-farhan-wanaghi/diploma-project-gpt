using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public Animator transitionAnimator;
    public float transitionTime = 1f;

    private bool isTransitioning = false;

    public void LoadScene()
    {
        if (isTransitioning)
        {
            return;
        }

        // Enable the SceneLoader object before starting the coroutine
        gameObject.SetActive(true);

        StartCoroutine(LoadSceneCoroutine());
    }

    IEnumerator LoadSceneCoroutine()
    {
        isTransitioning = true;

        // Play the transition animation
        if (transitionAnimator != null)
        {
            transitionAnimator.SetTrigger("Start");
        }

        // Wait for the animation to finish
        yield return new WaitForSeconds(transitionTime);

        // Load the next scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        isTransitioning = false;
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
