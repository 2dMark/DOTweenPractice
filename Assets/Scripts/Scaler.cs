using DG.Tweening;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private Vector3 _position;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private Ease _ease;

    private Tween _tween;

    private void Start()
    {
        _tween = transform.DOScale(_position, _duration);
        _tween.SetLoops(_repeats, _loopType);
        _tween.SetEase(_ease);
    }
}