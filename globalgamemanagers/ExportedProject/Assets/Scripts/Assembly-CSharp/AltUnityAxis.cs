using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000005")]
public class AltUnityAxis
{
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x18")]
	public string negativeButton;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x20")]
	public string positiveButton;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x28")]
	public string altPositiveButton;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x30")]
	public string altNegativeButton;

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xAD5AF8", Offset = "0xAD5AF8", VA = "0xAD5AF8")]
	public AltUnityAxis(string name, string negativeButton, string positiveButton, string altPositiveButton, string altNegativeButton)
	{
	}
}
