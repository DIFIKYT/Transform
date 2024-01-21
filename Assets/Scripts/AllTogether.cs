using UnityEngine;

public class AllTogether : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotateSpeed;
    [SerializeField] private float _scaleSpeed;

    private void Update()
    {
        MoveRotateScale();
        DrawRayInDirection();
    }

    private void MoveRotateScale()
    {
        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * _rotateSpeed * Time.deltaTime);
        transform.localScale += new Vector3(_scaleSpeed, _scaleSpeed, _scaleSpeed) * Time.deltaTime;
    }

    private void DrawRayInDirection()
    {
        Debug.DrawRay(transform.position, transform.forward * 5f, Color.red);
    }
}