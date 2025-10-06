using UnityEngine;

public class RotationAroundSelfAnimation : BaseAnimation
{
    protected override void Play()
        => transform.Rotate(Vector3.up, _speed, Space.Self);
}