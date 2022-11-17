using Assets.AltUnityTester.AltUnityDriver.UnityStruct;
using Il2CppDummyDll;

[Token(Token = "0x200000D")]
public struct AltUnityTextureInformation
{
	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x0")]
	public byte[] imageData;

	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x8")]
	public AltUnityVector2 scaleDifference;

	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x10")]
	public AltUnityVector3 textureSize;

	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x1C")]
	public AltUnityTextureFormat textureFormat;

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x89DF6C", Offset = "0x89DF6C", VA = "0x89DF6C")]
	public AltUnityTextureInformation(byte[] imageData, AltUnityVector2 scaleDifference, AltUnityVector3 textureSize, AltUnityTextureFormat textureFormat)
	{
	}
}
