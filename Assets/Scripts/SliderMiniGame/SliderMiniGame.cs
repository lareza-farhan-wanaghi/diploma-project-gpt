using UnityEngine;
using UnityEngine.UI;

public class SliderMiniGame : MonoBehaviour
{
    public Slider slider;
    public float sliderSpeed = 1f;
    public float successRangeDistance = 0.2f;
    private float originalSuccessRangeDistance;
    public int successCountNeeded = 3;
    public GameObject successRangeVisualizer;

    private float successRangeStart;
    private float successRangeEnd;
    private int successCount = 0;
    private bool isMiniGameRunning = false;
    private string miniGameString;

    private void Start()
    {
        // Disable the slider game object by default
        slider.gameObject.SetActive(false);

        // Disable the success range visualizer game object by default
        successRangeVisualizer.SetActive(false);
        originalSuccessRangeDistance = successRangeDistance;
    }

    public void StartMiniGame(string miniGameString)
    {
        FindObjectOfType<MainCharacter>().SetEnableInputs(false);

        this.miniGameString = miniGameString;

        // Enable the slider game object and reset its value to 0.5
        slider.gameObject.SetActive(true);
        slider.value = 0.5f;

        // Enable the success range visualizer game object and set its initial width
        successRangeVisualizer.SetActive(true);
        successRangeVisualizer.GetComponent<RectTransform>().sizeDelta = new Vector2(slider.GetComponent<RectTransform>().rect.width * successRangeDistance, successRangeVisualizer.GetComponent<RectTransform>().rect.height);

        // Set the success count to 0
        successCount = 0;

        successRangeDistance = originalSuccessRangeDistance;

        // Randomize the success range for the first time
        RandomizeSuccessRange();

        // Start moving the slider
        isMiniGameRunning = true;
    }

    private void Update()
    {
        if (isMiniGameRunning)
        {
            // Move the slider back and forth between 0 and 1
            slider.value = Mathf.PingPong(Time.time * sliderSpeed, 1f);

            if (Input.GetKeyDown(KeyCode.K))
            {
                // Check if the slider value is within the success range
                if (slider.value >= successRangeStart && slider.value <= successRangeEnd)
                {
                    successCount++;

                    // Decrease the success range distance by 0.05 times the success count
                    successRangeDistance -= 0.05f * successCount;

                    // Check if the success range distance has become too small
                    if (successRangeDistance <= 0f)
                    {
                        successRangeDistance = 0f;
                    }

                    // Check if the player has succeeded enough times
                    if (successCount >= successCountNeeded)
                    {
                        // Disable the slider game object and stop the mini-game
                        slider.gameObject.SetActive(false);
                        isMiniGameRunning = false;

                        EventSystem.instance.ProceedEvent(new EventData(IngameEventType.AddingAPhoto, miniGameString));
                        Sprite photoSprite = Resources.Load<Sprite>("Photos/" + miniGameString);
                        SliderPopup.Instance.Show(photoSprite);
                        GameObject.Find(miniGameString).SetActive(false);
                        FindObjectOfType<MainCharacter>().SetEnableInputs(true);
                    }
                    else
                    {
                        // Randomize the success range again
                        RandomizeSuccessRange();
                    }
                }
            }
        }
    }

    private void RandomizeSuccessRange()
    {
        // Generate a random success range with the specified distance
        successRangeStart = Random.Range(0f, 1f - successRangeDistance);
        successRangeEnd = successRangeStart + successRangeDistance;

        // Set the position and width of the success range visualizer
        float sliderWidth = slider.GetComponent<RectTransform>().rect.width;
        float sliderHeight = slider.GetComponent<RectTransform>().rect.height;
        float startPosX = successRangeStart * sliderWidth;
        float width = successRangeDistance * sliderWidth;
        successRangeVisualizer.GetComponent<RectTransform>().anchoredPosition = new Vector2(startPosX, 0f);
        successRangeVisualizer.GetComponent<RectTransform>().sizeDelta = new Vector2(width, sliderHeight * 0.4f);
    }
}
