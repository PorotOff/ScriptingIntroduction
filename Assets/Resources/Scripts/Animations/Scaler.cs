using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
        => ChangeScale();

    private void ChangeScale()
        => transform.localScale += Vector3.one * _speed * Time.deltaTime;
}