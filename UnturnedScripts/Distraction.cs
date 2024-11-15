using UnityEngine;

namespace SDG.Unturned;

// Starts with a 2.5 second delay then creates a zombie distraction(24 meters radius)
// One use only

public class Distraction : MonoBehaviour
{
    public void Distract()
    {
        AlertTool.alert(base.transform.position, 24f);
        Object.Destroy(this);
    }

    private void Start()
    {
        Invoke("Distract", 2.5f);
    }
}
