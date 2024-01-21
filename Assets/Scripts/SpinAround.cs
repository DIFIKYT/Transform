using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinAround : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Spin();
    }

    private void Spin()
    {
        transform.Rotate(Vector3.up * _speed * Time.deltaTime);
    }
}