using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public void MoveUp()
    {
        transform.position += Vector3.up;
    }

    public void MoveDown()
    {
        transform.position += Vector3.down;
    }

    public void MoveLeft()
    {
        transform.position += Vector3.left;
    }

    public void MoveRight()
    {
        transform.position += Vector3.right;
    }
}