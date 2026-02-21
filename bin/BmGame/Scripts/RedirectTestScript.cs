using BmSDK.BmGame;

public static partial class GlobalRedirects
{
    // Global redirect which works no matter the script components attached
    [Redirect(typeof(RPawnPlayer), nameof(RPawnPlayer.ExperienceAwarded))]
    public static void ExperienceAwardedRedirect(RPawnPlayer self, int xp, int teethXp)
    {
        Debug.Log($"Global: [xp={xp}, teethXp={teethXp}]");
        self.ExperienceAwarded(xp, teethXp);
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
        Debug.Log($"Local : [xp={xp}, teethXp={teethXp}]");
        Owner.ExperienceAwarded(xp / 10, teethXp / 10);
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
