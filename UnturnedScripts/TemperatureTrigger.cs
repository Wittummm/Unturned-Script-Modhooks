using UnityEngine;

namespace SDG.Unturned;

// - Wittummm
// Adds a sphere of a certain temperature

public class TemperatureTrigger : MonoBehaviour
{
    public EPlayerTemperature temperature;

    private TemperatureBubble bubble;

    private void OnEnable()
    {
        if (bubble == null)
        {
            bubble = TemperatureManager.registerBubble(base.transform, base.transform.localScale.x, temperature);
        }
    }

    private void OnDisable()
    {
        if (bubble != null)
        {
            TemperatureManager.deregisterBubble(bubble);
            bubble = null;
        }
    }
}
