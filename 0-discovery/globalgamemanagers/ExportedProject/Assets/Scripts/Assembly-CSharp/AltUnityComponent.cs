using Il2CppDummyDll;

[Token(Token = "0x2000006")]
public struct AltUnityComponent
{
	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x0")]
	public string componentName;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x8")]
	public string assemblyName;

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x89C194", Offset = "0x89C194", VA = "0x89C194")]
	public AltUnityComponent(string componentName, string assemblyName)
	{
	}
}
