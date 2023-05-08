using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PrologueSystem : MonoBehaviour
{
    public List<PrologueData> prologueDataList;
    public Image imageUI;
    public TextMeshProUGUI textUI;
    public SceneLoader sceneLoader;

    private int currentDataIndex = 0;

    void Start()
    {
        gameObject.SetActive(false);
    }

    public void ShowPrologue()
    {
        gameObject.SetActive(true);
        ShowData(0);
    }

    void ShowData(int dataIndex)
    {
        if (dataIndex >= prologueDataList.Count)
        {
            sceneLoader.LoadScene();
            return;
        }

        PrologueData data = prologueDataList[dataIndex];
        imageUI.sprite = data.image;
        textUI.text = data.text;

        currentDataIndex = dataIndex;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            ShowData(currentDataIndex + 1);
        }
    }
}
