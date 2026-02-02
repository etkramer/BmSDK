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
