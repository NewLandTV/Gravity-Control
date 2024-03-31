using UnityEngine;

public class GoalPoint : MonoBehaviour
{
    private Stage stage;

    private void Awake()
    {
        stage = GetComponentInParent<Stage>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Object"))
        {
            stage.NextStage();
        }
    }
}
