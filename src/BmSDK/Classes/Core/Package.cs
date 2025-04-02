namespace BmSDK;

public partial class Package
{
    public static Package GetTransientPackage() =>
        _transientPackage ??= StaticFindObjectChecked<Package>(null, null, "Transient", false);

    static Package? _transientPackage = null;

    // TODO
}
