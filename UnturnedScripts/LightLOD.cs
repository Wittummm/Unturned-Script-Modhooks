using UnityEngine;

namespace SDG.Unturned;

// - Wittummm
// Fades out lights at a certain distance and disables them to improve performance.

public class LightLOD : MonoBehaviour
{
    /// <summary>
    /// Prevents static member from being initialized during MonoBehaviour construction. (Unity warning)
    /// </summary>
    private static class HelperClass
    {
        public static CommandLineFlag disableLightLods = new CommandLineFlag(defaultValue: false, "-DisableLightLODs");
    }

    public Light targetLight;

    private float intensityStart;

    private float transitionStart;

    private float transitionEnd;

    private float transitionMagnitude;

    private float sqrTransitionStart;

    private float sqrTransitionEnd;

    private void apply()
    {
        if (targetLight == null || targetLight.type == LightType.Area || targetLight.type == LightType.Directional || MainCamera.instance == null)
        {
            return;
        }
        Vector3 vector = base.transform.position - MainCamera.instance.transform.position;
        float sqrMagnitude = vector.sqrMagnitude;
        if (sqrMagnitude < sqrTransitionStart)
        {
            if (!targetLight.enabled)
            {
                targetLight.intensity = intensityStart;
                targetLight.enabled = true;
            }
            return;
        }
        if (sqrMagnitude > sqrTransitionEnd)
        {
            if (targetLight.enabled)
            {
                targetLight.intensity = 0f;
                targetLight.enabled = false;
            }
            return;
        }
        float t = (vector.magnitude - transitionStart) / transitionMagnitude;
        targetLight.intensity = Mathf.Lerp(intensityStart, 0f, t);
        if (!targetLight.enabled)
        {
            targetLight.enabled = true;
        }
    }

    private void Update()
    {
        apply();
    }

    private void Start()
    {
        if (targetLight == null || targetLight.type == LightType.Area || targetLight.type == LightType.Directional || (bool)HelperClass.disableLightLods)
        {
            base.enabled = false;
            return;
        }
        intensityStart = targetLight.intensity;
        if (targetLight.type == LightType.Point)
        {
            transitionStart = targetLight.range * 13f;
            transitionEnd = targetLight.range * 15f;
        }
        else if (targetLight.type == LightType.Spot)
        {
            transitionStart = Mathf.Max(64f, targetLight.range) * 1.75f;
            transitionEnd = Mathf.Max(64f, targetLight.range) * 2f;
        }
        transitionMagnitude = transitionEnd - transitionStart;
        sqrTransitionStart = transitionStart * transitionStart;
        sqrTransitionEnd = transitionEnd * transitionEnd;
        apply();
    }
}
