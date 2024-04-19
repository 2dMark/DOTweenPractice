using DG.Tweening;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 _position;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private Ease _ease;

    private Tween _tween;

    private void Start()
    {
        _tween = transform.DORotate(_position, _duration, RotateMode.FastBeyond360);
        _tween.SetLoops(_repeats);
        _tween.SetEase(_ease);
    }
}