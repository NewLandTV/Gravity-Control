using UnityEngine;

public class GravityController : MonoBehaviour
{
    [SerializeField]
    private float scale = 9.81f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Physics2D.gravity = Vector3.up * scale;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Physics2D.gravity = Vector3.down * scale;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Physics2D.gravity = Vector3.left * scale;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Physics2D.gravity = Vector3.right * scale;
        }
    }
}
