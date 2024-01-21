using UnityEngine;

public class IncreaseSize : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Increase();
    }

    private void Increase()
    {
        transform.localScale += new Vector3(_speed, _speed, _speed) * Time.deltaTime;
    }
}