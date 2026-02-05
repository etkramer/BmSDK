using BmSDK.BmGame;

public static class GlobalRedirects
{
    // Global redirect which works no matter the script components attached
    [Redirect(typeof(RPawnPlayer), nameof(RPawnPlayer.ExperienceAwarded))]
    public static void ExperienceAwardedRedirect(RPawnPlayer self, int xp, int teethXp)
    {
        self.ExperienceAwarded(xp, teethXp);
        self.PlayerController.HudMovieNew.GeneralMovie.SetInfoText(
            "Default regeneration",
            (int) RGFxMovieHudExtendable.JustifyText.JT_Center,
            TextColour: 0x00FF00
        );
    }
}

[ScriptComponent]
public sealed class RegenReductionComponent : ScriptComponent<RPawnPlayer>
{
    public override void OnAttach() => Debug.Log("RegenReductionComponent attached to player pawn!");

    public override void OnDetach() => Debug.Log("RegenReductionComponent detached to player pawn!");

    // Local redirect which only applies to actors with the script component attached
    // Overrides the global redirect
    [ComponentRedirect(nameof(RPawnPlayer.ExperienceAwarded))]
    public void ExperienceAwardedRedirect(int xp, int teethXp)
    {
        Owner.ExperienceAwarded(xp / 10, teethXp / 10);
        Owner.PlayerController.HudMovieNew.GeneralMovie.SetInfoText(
            "Reduced regeneration",
            (int) RGFxMovieHudExtendable.JustifyText.JT_Center,
            TextColour: 0xFF0000
        );
    }
}

[Script]
public class RedirectTestScript : Script
{
    public override void OnKeyDown(Keys key)
    {
        if (key != Keys.N)
        {
            return;
        }

        var rpp = Game.GetPlayerPawn();
        // You may only attach one ScriptComponent instance of a given type
        // Therefore, we can check if the SC is attached using generics
        if (!rpp.HasScriptComponent<RegenReductionComponent>())
        {
            rpp.AttachScriptComponent<RegenReductionComponent>();
        }
        else
        {
            rpp.DetachScriptComponent<RegenReductionComponent>();
        }
    }
}
