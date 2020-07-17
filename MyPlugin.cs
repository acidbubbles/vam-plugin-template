using System;

public class MyPlugin : MVRScript
{
    public override void Init()
    {
        try
        {
            SuperController.LogMessage($"{nameof(MyPlugin)} initialized");
        }
        catch (Exception e)
        {
            SuperController.LogError($"{nameof(MyPlugin)}.{nameof(Init)}: {e}");
        }
    }

    public void OnEnable()
    {
        try
        {
            SuperController.LogMessage($"{nameof(MyPlugin)} enabled");
        }
        catch (Exception e)
        {
            SuperController.LogError($"{nameof(MyPlugin)}.{nameof(OnEnable)}: {e}");
        }
    }

    public void OnDisable()
    {
        try
        {
            SuperController.LogMessage($"{nameof(MyPlugin)} disabled");
        }
        catch (Exception e)
        {
            SuperController.LogError($"{nameof(MyPlugin)}.{nameof(OnDisable)}: {e}");
        }
    }

    public void OnDestroy()
    {
        try
        {
            SuperController.LogMessage($"{nameof(MyPlugin)} destroyed");
        }
        catch (Exception e)
        {
            SuperController.LogError($"{nameof(MyPlugin)}.{nameof(OnDestroy)}: {e}");
        }
    }
}
