using UnityEngine;

namespace SDG.Unturned;

// - Wittummm
// Requires a Collider with 'isTrigger' set to True
// When Player collides it will give the achievement
// The name of the GameObject should be the achievement ID

public class Achievement : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!Dedicator.IsDedicatedServer && other.transform.CompareTag("Player") && !(other.transform != Player.player.transform) && Provider.provider.achievementsService.getAchievement(base.transform.name, out var has) && !has)
        {
            Provider.provider.achievementsService.setAchievement(base.transform.name);
        }
    }
}
