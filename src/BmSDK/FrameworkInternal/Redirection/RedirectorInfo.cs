using System.Reflection;

namespace BmSDK.Framework.Redirection;

record RedirectorInfo(Type TargetClass, MethodInfo RedirectMethod, object? RedirectTarget);
