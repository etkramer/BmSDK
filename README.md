# BmSDK
[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE.md)

## 📖 About
<img height="656" alt="Screenshot 2025-08-23 at 5 05 46 PM" src="https://github.com/user-attachments/assets/75e1de77-5805-4bde-b25c-ddc9481c49d3" />

BmSDK is a **C# scripting system** for Batman: Arkham City that lets you create mods with custom gameplay and logic. It provides a full game-mapped API _(RPlayerController, WorldInfo, RGameRI, etc.)_ along with utilities for interacting with the game world. It also provides **lifecycle and input events** (script start, enter menu/game, tick, button press, etc.). Check out the [wiki](../../wiki) for more info!

---

## 🚀 Getting started (for users)
If you just want to run script mods (not create them), getting started is simple:
1. Download and install the [.NET 10 SDK (x86)](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-10.0.102-windows-x86-installer) if you haven't already. Make sure you get the 32-bit version (x86), even if you have a 64-bit computer.
2. Download the latest release from [releases](../../releases/latest) and open the .zip file.
3. Inside you'll see two folders: `Binaries` and `BmGame`. Copy both into your game folder (likely `C:\Program Files\Epic Games\BatmanArkhamCity`). Your game folder should already contain folders with these names.
4. Done, BmSDK is installed! Now to install script mods, simply drop any .cs files into your `BmGame\Scripts` folder.

Keep in mind that script mods can potentially harm your computer. Make sure you only download and install scripts from trusted sources.

### ⚠️ Notice for non-Epic Games Store users:
If you have a Steam or GOG copy of the game, you'll need to install a compatibility patch. You can find it alongside the [latest release](../../releases/latest). Extract the ZIP and copy the `Binaries` folder into your game directory. When prompted, replace `BatmanAC.exe` — it's a good idea to back up the original first.

---

## 🧩 Setting Up for Mod Development
Follow these steps to set up your environment for building, running, and debugging mods:
1. Go to [visualstudio.microsoft.com/downloads](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&channel=Stable) and run the Visual Studio Installer.
2. In the Visual Studio Installer, select "**.NET desktop development**" from the _Workloads_ tab.
3. Follow all the steps in the [user setup](#-getting-started-for-users), except you can skip the .NET SDK since it's included with Visual Studio.
4. Start Visual Studio and open the solution in `%GameDir%\BmGame\ScriptsDev`.
5. Write your code in any C# source file in `%GameDir%\BmGame\Scripts`.
6. Run your code by pressing **F5** in Visual Studio.
7. Follow the [wiki](../../wiki/Creating-your-first-mod) to write your first script.

## 🛠️ Preparing to Extend BmSDK Itself
To set up your environment for modifying and building BmSDK itself, see the wiki: [Building BmSDK](../../wiki/Building-BmSDK)

---

## 📋 Licence
BmSDK is licenced under the [MIT licence](LICENSE.md).
