namespace BmSDK.BmGame;

public partial class RBMPawnAI
{
    /// <summary>
    /// Sets up this RBMPawnAI to use the given character.
    /// </summary>
    public void InitCharacter(Class characterClass, Class? weaponType = null)
    {
        InitCharacter(new FInitCharacterDescription { Character = characterClass, WeaponType = weaponType });
    }
}
