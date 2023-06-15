using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PrologueSystem : MonoBehaviour
{
    public List<PrologueData> prologueDataList;
    public TextMeshProUGUI textUI;
    public SceneLoader sceneLoader;
    [SerializeField] Animator prologAnim;
    private int currentDataIndex = 0;
    [SerializeField] bool isAutoShow = false;

    void Start()
    {
        
        if(isAutoShow){
            ShowPrologue();
        }
        else{
            gameObject.SetActive(false);
        }
    }

    public void ShowPrologue()
    {
        gameObject.SetActive(true);
        ShowData(0);
    }

    void ShowData(int dataIndex)
    {
        currentDataIndex = dataIndex;
        if (dataIndex >= prologueDataList.Count)
        {
            prologAnim.PlayInFixedTime("Hide",0,0);
            sceneLoader.LoadScene();
            return;
        }

        PrologueData data = prologueDataList[dataIndex];
        textUI.text = data.text;
        prologAnim.PlayInFixedTime("Show",0,0);        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K) && currentDataIndex < prologueDataList.Count )
        {
            ShowData(currentDataIndex + 1);
        }
    }
}
