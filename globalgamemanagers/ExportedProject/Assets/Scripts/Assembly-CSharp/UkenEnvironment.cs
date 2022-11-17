using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200020B")]
public abstract class UkenEnvironment : ScriptableObject
{
	[Token(Token = "0x4000B87")]
	[FieldOffset(Offset = "0x18")]
	public string AndroidHome;

	[Token(Token = "0x4000B88")]
	private const string METACONFIG_PATH = "Assets/Resources/environment.txt";

	[Token(Token = "0x4000B89")]
	public const string mc_sDefaultEnvironment = "staging";

	[Token(Token = "0x6000DB7")]
	[Address(RVA = "0xB49950", Offset = "0xB49950", VA = "0xB49950")]
	public static string CurrentName()
	{
		return null;
	}

	[Token(Token = "0x6000DB8")]
	[Address(RVA = "0xB49A80", Offset = "0xB49A80", VA = "0xB49A80")]
	public static UkenEnvironment LoadCurrent()
	{
		return null;
	}

	[Token(Token = "0x6000DB9")]
	[Address(RVA = "0xB49B5C", Offset = "0xB49B5C", VA = "0xB49B5C")]
	protected UkenEnvironment()
	{
	}
}
