using System.Collections;
using UnityEngine;

public class Stage : MonoBehaviour
{
    [SerializeField]
    private GameObject square;

    [SerializeField]
    private UI ui;

    private StageInfo[] stages;

    private ushort currentStage;
    public ushort CurrentStage => currentStage;

    private WaitForSeconds waitTime2f;

    private void Awake()
    {
        stages = GetComponentsInChildren<StageInfo>(true);

        waitTime2f = new WaitForSeconds(2f);
    }

    public void NextStage()
    {
        if (currentStage + 1 >= stages.Length)
        {
            ui.ShowEndingUI();

            return;
        }

        square.SetActive(false);

        square.transform.position = Vector3.zero;

        stages[currentStage++].gameObject.SetActive(false);
        stages[currentStage].gameObject.SetActive(true);

        StartCoroutine(NextStageCoroutine());
    }

    private IEnumerator NextStageCoroutine()
    {
        yield return waitTime2f;

        square.SetActive(true);
    }
}
