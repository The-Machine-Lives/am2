using Assets.AltUnityTester.AltUnityDriver.UnityStruct;
using Il2CppDummyDll;

[Token(Token = "0x200002A")]
public class AltUnitySwipeAndWait : AltBaseCommand
{
	[Token(Token = "0x4000092")]
	[FieldOffset(Offset = "0x38")]
	private AltUnityVector2 start;

	[Token(Token = "0x4000093")]
	[FieldOffset(Offset = "0x40")]
	private AltUnityVector2 end;

	[Token(Token = "0x4000094")]
	[FieldOffset(Offset = "0x48")]
	private float duration;

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xC18814", Offset = "0xC18814", VA = "0xC18814")]
	public AltUnitySwipeAndWait(SocketSettings socketSettings, AltUnityVector2 start, AltUnityVector2 end, float duration)
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xC188E8", Offset = "0xC188E8", VA = "0xC188E8")]
	public void Execute()
	{
	}
}
