namespace BmSDK;

public partial class Package
{
    /// <summary>
    /// Returns the transient package. This is the recommended outer for temporary objects.
    /// </summary>
    public static Package GetTransientPackage() =>
        _transientPackage ??= StaticFindObjectChecked<Package>(null, null, "Transient", false);

    private static Package? _transientPackage = null;
}
