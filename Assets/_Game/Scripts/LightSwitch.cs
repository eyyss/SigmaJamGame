using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour, IClickable
{
    public List<Light> lights;
    public bool self=true;
    public string info;

    void Start()
    {
        foreach (Light light in lights)
        {
            light.enabled = self;
        }
    }
    public void OnClick()
    {
        self = !self;
        foreach (Light light in lights)
        {
            light.enabled = self;
        }
    }

    public string GetInfo()
    {
        return info;
    }
}
