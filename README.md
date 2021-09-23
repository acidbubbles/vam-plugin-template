# Virt-A-Mate Plugin Template for VSCode

## What you will need

- [Visual Studio Code](https://code.visualstudio.com/) to edit your plugins
- [.NET Core SDK](https://dotnet.microsoft.com/download) to compile your code (optional)
- [.NET Framework 3.5 Targeting Pack](https://stackoverflow.com/a/47621616/154480) (you might already have this)
- [Virt-A-Mate](https://www.patreon.com/meshedvr/) to use your plugins

## Get this template

First of all, decide what your author name will be, and what your plugin name will be. From now on, replace `Author` and `MyPlugin` by your selected name. I suggest your keep those simple without any special characters.

- If you have a GitHub account (recommended), click on `Use this template` on the [vam-plugin-template](https://github.com/acidbubbles/vam-plugin-template). It will create your own copy. You can also [download](https://github.com/acidbubbles/vam-plugin-template/archive/master.zip) this repository.
- Clone (or unzip) this repo under `(VaM install path)\Custom\Scripts\Author\MyPlugin`, replacing `Author` and `MyPlugin` by yours, so that the `MyPlugin.cs` is directly under the `MyPlugin` folder.

You should now be able to open the project in vscode by using `File`, `Open Folder` and select the `MyPlugin` folder.

## Adapt the template

- Rename the `MyPlugin.cs` and `MyPlugin.csproj` to match your plugin name.
- Replace in files (<kbd>ctrl</kbd> + <kbd>shift</kbd> + <kbd>h</kbd>) all occurences of `Author` and `MyPlugin` by yours.
- In `meta.json`, fill in the description (keep `v0.0.0` if you plan on using GitHub Actions), credits, instructions and promotionalLink. You might also want to chage the `licenseType`, if you wish.
- Replace the content of `README.md` by your own content.
- Replace the author name in [LICENSE.md](LICENSE.md) file to put your own name (it's all right, you have my blessing!)

## About `MVRScript`

The plugin is really a Unity [MonoBehavior](https://docs.unity3d.com/ScriptReference/MonoBehaviour.html), which means you can use methods like `Update`, `FixedUpdate`, `OnEnable`, `OnDisable` and `OnDestroy`. `Init` however is called by Virt-A-Mate.

Keep in mind however that `OnEnable` will be called _before_ `Init`.

## Validate locally

You can run `dotnet build` in the plugin folder, and it'll show you any compilation errors. This is faster than going in VaM to do so! I recommend installing .NET 5 or more recent.

## Package var using GitHub Actions

If you use `GitHub`, you can push a tag with the naming convention `v0.0.0`, and it will automatically create a release draft. You can then edit it (e.g. add a description) and publish it.

## Learning about Git

There are tons of references out there, you might want to look at [GitHub Learning Lab](https://lab.github.com/). Learning Git is _really_ worth your time.

## License

[MIT](LICENSE.md)
