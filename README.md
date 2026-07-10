# BmSDK for Arkham City
[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE.md)

<img height="656" alt="Screenshot 2025-08-23 at 5 05 46 PM" src="https://github.com/user-attachments/assets/75e1de77-5805-4bde-b25c-ddc9481c49d3" />

## 📖 About
BmSDK is a scripting platform for Batman: Arkham City and [Batman: Arkham Knight](https://github.com/etkramer/BmSDK-AK), allowing you to extend the game with C# code for custom gameplay and logic.

It gives you access to a full SDK for working with the game and its world, based on the engine's own UnrealScript API - for example, a short script to spawn in Joker near the player:
```cs
using BmSDK;
using BmSDK.BmGame;
using BmSDK.BmScript;

[Script]
public class DemoScript : Script
{
    public override void OnKeyDown(Keys key)
    {
        if (key == Keys.J)
        {
            var playerPawn = Game.GetPlayerPawn();

            // Load .upk with RCharacter_Joker
            Game.LoadPackage("FunFair");

            // Spawn in Joker
            var newCharacter = new RPawnVillainThug(playerPawn.Location, playerPawn.Rotation);
            newCharacter.InitCharacter(RCharacter_Joker.StaticClass());

            // Move Joker in front of the player
            var playerDir = playerPawn.Rotation.ToDirection() with { Z = 0 };
            newCharacter.Move(playerDir * 100);
        }
    }
}
```

Check out the [wiki](../../wiki) for more info!

## 🚀 Getting started
If you want to play script mods, getting started is simple:
1. Download and install the [.NET 10 Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-10.0.3-windows-x86-installer) if you haven't already. Make sure you get the 32-bit version (x86), even if you have a 64-bit computer.
2. Download the latest release from [releases](../../releases/latest) and open the .zip file.
3. Inside you'll see two folders: `Binaries` and `BmGame`. Copy both to your game folder (likely `C:\Program Files\Epic Games\BatmanArkhamCity`). There should already be 2 folders in there with the same names.
4. Done, BmSDK is installed! Now to install script mods, simply drop any .cs files into your `BmGame\Scripts` folder.

Keep in mind that script mods can potentially harm your computer. Make sure you only download and install scripts from trusted sources.

### ⚠️ Notice for Steam or GOG users:
If you have a Steam or GOG copy of the game, you'll have to install a compatibility patch. You can download it [here](../../releases/download/v0.15.1/CompatibilityPatch.zip), just replace the `BatmanAC.exe` from your game folder (see below) with the one provided. It's a good idea to make a backup first.

## 🧩 Setting Up for Mod Development
Follow these steps to set up your environment for building, running, and debugging script mods:
1. Go to [visualstudio.microsoft.com/downloads](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&channel=Stable) and run the Visual Studio Installer.
2. In the Visual Studio Installer, select "**.NET desktop development**" from the _Workloads_ tab.
3. Follow all the steps in the [user setup](#-getting-started-for-users), except you can skip installing .NET because it's already included with Visual Studio.
4. Start Visual Studio and open the solution in `%GameDir%\BmGame\ScriptsDev`.
5. Write your code in any C# source file in `%GameDir%\BmGame\Scripts`.
6. Run your code by pressing **F5** in Visual Studio.
7. Follow the [wiki](../../wiki/Creating-your-first-mod) to write your first script.

## 🛠️ Contributing
To get started contributing to BmSDK, see the wiki for instructions: [Building BmSDK](../../wiki/Building-BmSDK)

## 📋 License
BmSDK is licenced under the [MIT licence](LICENSE.md).
