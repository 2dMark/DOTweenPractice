using DG.Tweening;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Color _color;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private Ease _ease;

    private SpriteRenderer _spriteRenderer;
    private Tween _tween;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        _tween = _spriteRenderer.DOColor(_color, _duration);
        _tween.SetLoops(_repeats, _loopType);
        _tween.SetEase(_ease);
    }
}