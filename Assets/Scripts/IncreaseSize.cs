using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseSize : MonoBehaviour
{
    [SerializeField] private float _speed;
    private float _scaleX = 1;
    private float _scaleY = 1;
    private float _scaleZ = 1;

    private void Update()
    {
        Increase();
    }

    private void Increase()
    {
        _scaleX += _speed;
        _scaleY += _speed;
        _scaleZ += _speed;

        transform.localScale = new Vector3(_scaleX, _scaleY, _scaleZ);
    }
}