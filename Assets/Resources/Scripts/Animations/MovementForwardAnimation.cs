using UnityEngine;

public class MovementForwardAnimation : BaseAnimation
{
    protected override void Play()
        => transform.Translate(transform.forward * _speed, Space.Self);
}