using System.Reflection;

namespace BmSDK.Framework.Redirection;

record LocalRedirectorInfo(IScriptComponent Component, MethodInfo RedirectMethod);
