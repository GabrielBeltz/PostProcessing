using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class VolumeController : MonoBehaviour
{
    public bool sinVariation;
    [ContextMenuItem("Get", "GetVolume")]
    public Volume originalVolume;
    public Volume priorityVolume;

    private void Update()
    {
        if (sinVariation)
        {
            float newValue = Mathf.Sin(Time.time);
            priorityVolume.weight = Mathf.Abs(newValue);
        }
    }

    public void GetVolume()
    {
        originalVolume = this.GetComponent<Volume>();
    }
}
