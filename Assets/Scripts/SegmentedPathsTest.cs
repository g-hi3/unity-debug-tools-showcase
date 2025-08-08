using System.Linq;
using G_hi3.Debug;
using UnityEngine;

public sealed class SegmentedPathsTest : MonoBehaviour
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
    private bool loop;

    [SerializeField]
    private Transform[] pathPoints;

    private void Update()
    {
        var positions = pathPoints
            .Where(t => t != null)
            .Select(t => t.position)
            .ToArray();
        
        DebugTools.DrawSegmentedPath(
            positions,
            segmentLength,
            segmentSpacing,
            segmentColor,
            timeScale,
            depthTest,
            loop);
    }
}
