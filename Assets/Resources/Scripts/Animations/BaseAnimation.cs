using UnityEngine;

public abstract class BaseAnimation : MonoBehaviour
{
    [SerializeField] protected float _speed;

    private void FixedUpdate()
        => Play();

    protected abstract void Play();
}