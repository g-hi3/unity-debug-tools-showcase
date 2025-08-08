using G_hi3.Debug;
using UnityEngine;

public sealed class SegmentedLinesTest : MonoBehaviour
{
    [SerializeField]
    private Transform start;

    [SerializeField]
    private Transform end;

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

    private void Update()
    {
        DebugTools.DrawSegmentedLine(
            start.position,
            end.position,
            segmentLength,
            segmentSpacing,
            segmentColor,
            timeScale,
            depthTest);
    }
}
