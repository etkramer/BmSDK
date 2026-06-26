//
// A script demonstrating the basic workflow with scripts and common BmSDK APIs.
//

using BmSDK;
using BmSDK.BmGame;
using BmSDK.BmScript;
using BmSDK.Engine;

[Script]
public class DemoScript : Script
{
    /// <summary>
    /// Called called once when the engine first becomes ready.
    /// Do basic set up here.
    /// </summary>
    public override void Main()
    {
        // Boost snow intensity on CDO (template object)
        var defaultRainComponent = RRainComponent.StaticClass().DefaultObject as RRainComponent;
        defaultRainComponent?.ParticleCount *= 5;

        // Set max players (default and current/frontend)
        foreach (var gameInfo in GameObject.FindObjectsSlow<RGameInfo>())
        {
            gameInfo.MaxPlayers = 4;
        }
    }

    /// <summary>
    /// Called when you enter the main menu
    /// (game start up or when exiting session).
    /// </summary>
    public override void OnEnterMenu()
    {
        // Enable info display
        Game.GetGameViewportClient().bShowSessionDebug = true;
    }

    /// <summary>
    /// Called when entering the game world.
    /// </summary>
    public override void OnEnterGame()
    {
        // Enable 1-hit counters
        foreach (var counterMove in GameObject.FindObjectsSlow<RCombatMove_BatmanCounter>())
        {
            counterMove.bShouldKill = true;
        }
    }

    /// <summary>
    /// Called when a key is pressed during gameplay
    /// (not in pause screen).
    /// </summary>
    public override void OnKeyDown(Keys key)
    {
        // Debug actions based on key press.
        switch (key)
        {
            case Keys.Enter:
                DebugLoadGame();
                break;
            case Keys.T:
                DebugAddSplitScreenPlayer();
                break;
            case Keys.V:
                DebugToggleGhost();
                break;
        }
    }

    static void DebugLoadGame()
    {
        Debug.Log("Entering game");

        // Prevent corrupting current save slot
        var saveMan = Game.GetGameRI().SaveGameManager;
        saveMan.SetActiveStorySlotID(RSaveGameManager.StorySlots.StorySlot_Temp);

        // Enter demo world
        var console = Game.GetConsole();
        console.ConsoleCommand(
            "start batentry?Players=Playable_Batman?Area=CityZ_17,CityX_02,CityX_03,CityZ_13,CityZ_14,CityZ_16,CityZ_18,CityZ_T17?NoFadeOut?Flags=Batman_GlideBoost,Debug_Freeroam,Debug_Freeroam_Population,IsFreeRoam,Environmental_Analysis_Unlocked,OrganScannedInNormalGame,Map_WaypointEnabled,CityX_06_Penguin_Cache_Accessible?Chapters=0,1,F1,S0,K1,U1?Start=CityZ_Stage_1?PlayMusic"
        );
    }

    static void DebugToggleGhost()
    {
        Debug.Log("Toggling ghost");

        var cheatManager = Game.GetCheatManager();
        cheatManager.ToggleGhost();
    }

    static void DebugAddSplitScreenPlayer()
    {
        Debug.Log("Spawning P2");

        var gameViewport = Game.GetGameViewportClient();
        gameViewport.DesiredSplitscreenType = GameViewportClient.ESplitScreenType.eSST_2P_VERTICAL;
        gameViewport.CreatePlayer(1, out _, true);
    }
}
