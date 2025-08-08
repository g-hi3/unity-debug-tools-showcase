using G_hi3.Debug;
using UnityEngine;

public sealed class SegmentedRectanglesTest : MonoBehaviour
{
    [SerializeField]
    private Color segmentColor;

    [SerializeField]
    private float segmentLength;

    [SerializeField]
    private float segmentSpacing;

    [SerializeField]
    private float timeScale;

    [SerializeField]
    private bool depthTest;

    [SerializeField]
    private Vector2 margin;
    
    private Transform _transform;

    private void Awake()
    {
        _transform = GetComponent<Transform>();
    }

    private void Update()
    {
        var position = _transform.position;
        var rotation = _transform.rotation;
        var scale = new Vector2(_transform.localScale.x + margin.x, _transform.localScale.z + margin.y);
        
        DebugTools.DrawSegmentedRectangle(
            position,
            rotation,
            scale,
            segmentLength,
            segmentSpacing,
            segmentColor,
            timeScale,
            depthTest);
    }
}
