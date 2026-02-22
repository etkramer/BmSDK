using System.Reflection;

namespace BmSDK.Framework.Redirection;

/// <summary>
/// Defines the API contract for any kind of redirect no matter the backing implementation.
/// This is used to generalize global and local redirects when queuing them in
/// <see cref="RedirectManager.AquireRedirects(GameObject, string)"/>.
/// </summary>
interface IGenericRedirect
{
    /// <summary>
    /// Invoker to the actual custom implementation of the redirected function.
    /// </summary>
    MethodInvoker Invoker { get; }

    /// <summary>
    /// Function called from within the UObject::ProcessInternal() context to execute the redirect.
    /// </summary>
    unsafe void Run(GameObject selfObj, Function funcObj, FFrame* stackPtr, IntPtr Result);
}

/// <summary>
/// Record storing data of a currently registered global redirect necessary to execute it.
/// </summary>
/// <param name="TargetType">Type that the redirect applies to</param>
/// <param name="RedirectMethod">Method to call on redirect</param>
sealed record GlobalRedirectorInfo(
    Type TargetType,
    MethodInfo RedirectMethod
) : IGenericRedirect
{
    public MethodInvoker Invoker { get; } = MethodInvoker.Create(RedirectMethod);

    public unsafe void Run(GameObject selfObj, Function funcObj, FFrame* stackPtr, nint Result)
        => RedirectManager.Global.ExecuteRedirector(this, selfObj, funcObj, stackPtr, Result);
}

/// <summary>
/// Record storing data of a currently registered local redirect necessary to execute it.
/// </summary>
/// <param name="Component">The ScriptComponent that declares the redirect</param>
/// <param name="RedirectMethod">Method to call on redirect</param>
/// <param name="Invoker">The cached invoker of the redirect method</param>
sealed record LocalRedirectorInfo(
    IScriptComponent Component,
    MethodInfo RedirectMethod,
    MethodInvoker Invoker
) : IGenericRedirect
{
    public unsafe void Run(GameObject selfObj, Function funcObj, FFrame* stackPtr, nint Result)
        => RedirectManager.Local.ExecuteRedirector(this, selfObj, funcObj, stackPtr, Result);
}

/// <summary>
/// Record storing data necessary to register local redirects when a ScriptComponent is attached.
/// This is used to avoid unnecessary repeated reflection.
/// </summary>
/// <param name="TargetType">Type that the redirect applies to</param>
/// <param name="FuncPath">The UE3 declaration path of the method to redirect.
/// If the method is not defined in <see cref="TargetType"/>, path could lead to super.</param>
/// <param name="RedirectMethod">Method to call on redirect</param>
readonly record struct CachedLocalRedirector(Type TargetType, string FuncPath, MethodInfo RedirectMethod)
{
    public MethodInvoker Invoker { get; } = MethodInvoker.Create(RedirectMethod);
}

/// <summary>
/// Record storing the data necessary to call multiple redirectors recursively.
/// Used in <see cref="RedirectManager.ExecuteRedirector(GameObject, Function, string, FFrame*, nint)"/>.
/// </summary>
/// <param name="TargetObj">Object the method is run on</param>
/// <param name="TargetFunc">Method being redirected</param>
/// <param name="Redirs">Each redirect that still exists for the
/// particular call of <paramref name="TargetFunc"/></param>
readonly record struct RedirectCall(GameObject TargetObj, Function TargetFunc, Queue<IGenericRedirect> Redirs);
