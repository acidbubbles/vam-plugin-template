#define VAM_DIAGNOSTICS
using System;
using UnityEngine;

/// <summary>
/// MyPlugin Version 0.0.0
/// TODO: Enter a short description
/// Source: TODO: Enter the GitHub URL
/// </summary>
public class MyPlugin : MVRScript
{
    public override void Init()
    {
        try
        {
            // TODO: Implement this!
            SuperController.LogMessage("Plugin installed");

#if (VAM_DIAGNOSTICS)
            SuperController.LogMessage("This will only appear in debug mode");
#endif
        }
        catch (Exception e)
        {
            SuperController.LogError("Failed to initialize plugin: " + e);
        }
    }
}
