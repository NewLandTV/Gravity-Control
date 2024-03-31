using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI currentStageText;
    [SerializeField]
    private GameObject endingGroup;

    [SerializeField]
    private Stage stage;

    private void LateUpdate()
    {
        currentStageText.text = $"{stage.CurrentStage + 1} Stage";
    }

    public void ShowEndingUI()
    {
        Time.timeScale = 0f;

        endingGroup.SetActive(true);
    }

    public void OnRestartButtonClick()
    {
        SceneManager.LoadScene(0);

        Time.timeScale = 1f;
    }
}
