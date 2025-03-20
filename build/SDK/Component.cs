using BmSDK;
using BmSDK.Framework;

namespace BmSDK.Core;

public class Component : Framework.UObject
{
	public Type TemplateOwnerClass => (Type)GetPropertyValue(0, "UClassProperty");
	public string TemplateName => (string)GetPropertyValue(4, "UNameProperty");
}
