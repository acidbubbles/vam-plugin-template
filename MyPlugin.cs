public class MyPlugin : MVRScript
{
    private JSONStorableBool _myValueJSON;

    public override void Init()
    {
        // Example storable; you can also create string, float and action JSON storables
        _myValueJSON = new JSONStorableBool("My Storable", false);
        // You can listen to changes
        _myValueJSON.setCallbackFunction = (bool val) => SuperController.LogMessage($"MyPlugin: Received {val}");
        // You can use Register* methods to make your storable triggerable, and save and restore the value with the scene
        RegisterBool(_myValueJSON);
        // You can use Create* methods to add a control in the plugin's custom UI
        CreateToggle(_myValueJSON);
    }
}
