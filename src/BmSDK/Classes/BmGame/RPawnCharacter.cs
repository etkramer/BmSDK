namespace BmSDK.BmGame;

public partial class RPawnCharacter
{
    public void SetYawDegrees(float R) => SetYawRadians(R * (MathF.PI / 180));
}
