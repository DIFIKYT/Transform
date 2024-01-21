using UnityEngine;

public class MovingForward : MonoBehaviour
{
    [SerializeField] private Vector3 _movementDirection;

    private void Update()
    {
        MoveForward();
    }

    private void MoveForward()
    {
        transform.Translate(_movementDirection, Space.World);
    }
}