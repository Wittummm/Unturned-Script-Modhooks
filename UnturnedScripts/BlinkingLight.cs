using UnityEngine;

namespace SDG.Unturned;

// - Wittummm
// Blinks every second

public class BlinkingLight : MonoBehaviour
{
    public GameObject target;

    private float blinkTime;

    private void Update()
    {
        if (!(Time.time - blinkTime < 1f))
        {
            blinkTime = Time.time;
            target.SetActive(!target.activeSelf);
        }
    }
}
