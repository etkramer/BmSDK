namespace BmSDK;

[Flags]
public enum EFunctionFlags
{
    Final = 0x1, // Function is final (prebindable, non-overridable function).
    Defined = 0x2, // Function has been defined (not just declared).
    Iterator = 0x4, // Function is an iterator.
    Latent = 0x8, // Function is a latent state function.
    PreOperator = 0x10, // Unary operator is a prefix operator.
    Singular = 0x20, // Function cannot be reentered.
    Net = 0x40, // Function is network-replicated.
    NetReliable = 0x80, // Function should be sent reliably on the network.
    Simulated = 0x100, // Function executed on the client side.
    Exec = 0x200, // Executable from command line.
    Native = 0x400, // Native function.
    Event = 0x800, // Event function.
    Operator = 0x1000, // Operator function.
    Static = 0x2000, // Static function.
    HasOptionalParms = 0x4000, // Function has optional parameters
    Const = 0x8000, // Function doesn't modify this object.

    Public = 0x20000, // Function is accessible in all classes (if overridden, parameters much remain unchanged).
    Private = 0x40000, // Function is accessible only in the class it is defined in (cannot be overriden, but function name may be reused in subclasses.IOW: if overridden, parameters don't need to match, and Super.Func() cannot be accessed since it's private.)
    Protected = 0x80000, // Function is accessible only in the class it is defined in and subclasses (if overridden, parameters much remain unchanged).
    Delegate = 0x100000, // Function is actually a delegate.
    NetServer = 0x200000, // Function is executed on servers (set by replication code if passes check)
    HasOutParms = 0x400000, // function has out (pass by reference) parameters
    HasDefaults = 0x800000, // function has structs that contain defaults
    NetClient = 0x1000000, // function is executed on clients
}
