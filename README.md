# Virt-A-Mate MyPlugin

What you will need:

- [VS Code](https://code.visualstudio.com/) to edit your plugins
- [Virt-A-Mate](https://www.patreon.com/meshedvr/) to use your plugins

How to use this template:

1. Decide on a plugin name. Here we will call it `MySuperPlugin`.
2. Clone this repo: `git clone --depth=1 https://github.com/acidbubbles/vam-plugin-template.git MySuperPlugin` inside `(VaM install folder)\Saves\Scripts\Anonymous` where `Anonymous` would be your pseudonym. That will clone into `(VaM install folder)\Saves\Scripts\Anonymous\MySuperPlugin`.
3. Delete the `.git` folder.
4. Initialize a new repo of your own: `git init`.
5. Rename `MyPlugin.csproj` to `MySuperPlugin.csproj` and `src/MyPlugin.cs` to `src/MySuperPlugin.cs`.
6. Open `MySuperPlugin.csproj` and rename the `src/MyPlugin.cs` to `src/MySuperPlugin.cs`.
7. Open `src/MySuperPlugin.cs` and start coding! Look at the `TODO` lines and enter a meaningful description.
8. Save a few test scenes under `scenes` to make it easier to quickly test your plugin.
9. When you're done, use `./Publish.ps1 1.0.0` and a version of the code without `#if(VAM_DIAGNOSTIC)` sections will be generated.
10. Create your project on GitHub using the nomenclature `vam-mysuperplugin`, and push it there. It's not [that complicated](https://guides.github.com/activities/hello-world/)!
11. Remove those instructions from this `README.md` file and explain what it does, and how to use it.
12. Let the [world know](https://www.reddit.com/)!

## License

[MIT](LICENSE.md)
