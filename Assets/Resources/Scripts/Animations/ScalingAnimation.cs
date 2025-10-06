using UnityEngine;

public class ScalingAnimation : BaseAnimation
{
    protected override void Play()
        => transform.localScale = transform.localScale + Vector3.one * _speed;
}