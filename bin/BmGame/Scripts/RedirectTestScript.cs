using BmSDK.BmGame;

public static class GlobalRedirects
{
    // Global redirect which works no matter the script components attached
    [Redirect(typeof(RPawnPlayer), nameof(RPawnPlayer.ExperienceAwarded))]
    public static void ExperienceAwardedRedirect(RPawnPlayer self, int xp, int teethXp)
    {
        Debug.Log("Experiencing less...");
        self.ExperienceAwarded(xp / 10, teethXp / 10);
    }
}

[ScriptComponent(AutoAttach = true)]
public sealed class XRayActivatorComponent : ScriptComponent<RPawnPlayer>
{
    public override void OnAttach() => Debug.Log("XRayActivatorComponent attached to player pawn!");

    public override void OnDetach() => Debug.Log("XRayActivatorComponent attached to player pawn!");

    [Redirect(nameof(RPawnPlayer.ExperienceAwarded))]
    public void ExperienceAwardedRedirect(int xp, int teethXp)
    {
        Owner.PlayerController.bInvestigateMode = true;
        Owner.ExperienceAwarded(xp * 10, teethXp * 10);
    }
}
