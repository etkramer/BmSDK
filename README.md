# BmSDK

[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE.md)

## 📖 About

BmSDK is a C# **scripting system** for Batman: Arkham City, allowing mods to add custom gameplay and logic. BmSDK provides a full game-mapped API and SDK _(RPlayerController, WorldInfo, RGameRI, etc.)_ and a set of useful helper methods for interacting with the game world. BmSDK also provides **lifecycle and input events** (script start, enter menu/game, tick, button press). Check out the [wiki](../../wiki) for further insight.

<img height="656" alt="Screenshot 2025-08-23 at 5 05 46 PM" src="https://github.com/user-attachments/assets/75e1de77-5805-4bde-b25c-ddc9481c49d3" />

---

## 🚀 Getting started (for users)

If you're a user (meaning you just want to run script mods, not make them), getting started is simple:

1. Go to [https://dotnet.microsoft.com/en-us/download](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-8.0.414-windows-x86-installer) and install the .NET 8 SDK if you haven't already. Make sure you get the 32-bit version (x86), even if you have a 64-bit computer.
2. Download the latest release from [releases](../../releases/latest) and open the .zip file.
3. Inside you'll see two folders: `Binaries` and `BmGame`. Copy both to your game folder (likely `C:\Program Files\Epic Games\BatmanArkhamCity`). There should already be 2 folders in there with the same names.
4. Done, BmSDK is installed! Now to install script mods, simply drop any .cs files into your `BmGame\Scripts` folder.

Keep in mind that script mods can potentially harm your computer. Make sure you only download and install scripts from trusted sources.

### ⚠️ Notice for non-Epic Games Store users:

If you have a Steam/GOG copy of the game, you'll have to install a compatibility patch. You can find it next to the [latest release](../../releases/latest). Just extract the ZIP and drop the `Binaries` folder in the game directory. Replace `BatmanAC.exe` when prompted - it's a good idea to make a backup first.

---

## 🛠️ Setting Up for Mod Development

Follow these steps to set up the development environment so you can build, run, and debug mods for the game:

1. Go to [visualstudio.microsoft.com/downloads](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&channel=Stable) and run the Visual Studio Installer.
2. In the Visual Studio Installer: Pick "**.NET desktop development**" from the "_Workloads_" tab and "**.NET 8.0 Runtime (Long Term Support)**" from the "_Individual components_" tab.
3. Follow all the steps for the [user setup](#-getting-started-for-users) except installing the .NET 8 SDK as it's included with Visual Studio.
4. Start Visual Studio and open the solution in `%GameDir%\BmGame\ScriptsDev`.
5. Write your code in `MinimalScript.cs` or any other C# source file in `%GameDir%\BmGame\Scripts`.
6. Test your code by pressing **F5** in Visual Studio _(Running the BatmanAC debug profile)_.
7. Follow the [wiki](../../wiki) to understand the API better.

### 💡 Common development issues and their solutions

- Sometimes the debugger might not attach properly, which will result in the game window never showing up. Press **Ctrl + Shift + F5** _(Restart debugging)_ in that case.
- If the game doesn't start because the game's executable can't be found, open `...\ScriptsDev\Properties\launchSettings.json` and replace "**executablePath**" with the absolute path to `%GameDir%\Binaries\Win32\BatmanAC.exe` and "**workingDirectory**" with the absolute path to `%GameDir%\Binaries\Win32` (Don't forget to escape the backslashes).

---

## 📋 Licence

BmSDK is licenced under the [MIT licence](LICENSE.md).
