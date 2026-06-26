using BmSDK.BmGame;

[Script]
public class DebugScript : Script
{
    public override void OnKeyDown(Keys key)
    {
        if (key == Keys.Enter)
        {
            // Prevent corrupting current save slot
            var saveMan = Game.GetGameRI().SaveGameManager;
            saveMan.SetActiveStorySlotID(RSaveGameManager.StorySlots.StorySlot_Temp);

            // Enter world
            var console = Game.GetConsole();
            console.ConsoleCommand("start batentry?Players=Playable_Batman?Area=CityZ_17,CityX_02,CityX_03,CityZ_13,CityZ_14,CityZ_16,CityZ_18,CityZ_T17?NoFadeOut?Flags=Batman_GlideBoost,Debug_Freeroam,Debug_Freeroam_Population,IsFreeRoam,Environmental_Analysis_Unlocked,OrganScannedInNormalGame,Map_WaypointEnabled,CityX_06_Penguin_Cache_Accessible?Chapters=0,1,F1,S0,K1,U1?Start=CityZ_Stage_1?PlayMusic");
        }
    }
}