using Il2CppDummyDll;
using Uken.Framework.Casual;

[Token(Token = "0x20001CE")]
public class SplashSceneController : CasualSceneController
{
	[Token(Token = "0x4000A9E")]
	[FieldOffset(Offset = "0x50")]
	private bool m_bQuit;

	[Token(Token = "0x6000C59")]
	[Address(RVA = "0xA06F6C", Offset = "0xA06F6C", VA = "0xA06F6C", Slot = "10")]
	public override void OnSceneLoaded()
	{
	}

	[Token(Token = "0x6000C5A")]
	[Address(RVA = "0xA07070", Offset = "0xA07070", VA = "0xA07070", Slot = "11")]
	public override void HandleBackButtonPress()
	{
	}

	[Token(Token = "0x6000C5B")]
	[Address(RVA = "0xA0708C", Offset = "0xA0708C", VA = "0xA0708C")]
	public SplashSceneController()
	{
	}
}
