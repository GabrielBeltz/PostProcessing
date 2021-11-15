using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class VolumeController : MonoBehaviour
{
    [ContextMenuItem("Set", "EnableEffect")]
    public bool Activated;
    [ContextMenuItem("Get", "GetVolume")]
    public Volume volume;

    private void Start()
    {

    }

    public void EnableEffect()
    {
        
    }

    public void GetVolume()
    {
        volume = this.GetComponent<Volume>();
    }
}
