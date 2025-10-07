using UnityEngine;

public class Rotater : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
        => Rotate();

    private void Rotate()
        => transform.Rotate(Vector3.up, _speed * Time.deltaTime, Space.Self);
}