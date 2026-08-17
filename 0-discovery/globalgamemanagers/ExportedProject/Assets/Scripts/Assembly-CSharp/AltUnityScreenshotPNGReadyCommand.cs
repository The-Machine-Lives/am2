using Il2CppDummyDll;

[Token(Token = "0x2000063")]
internal class AltUnityScreenshotPNGReadyCommand : AltUnityCommand
{
	[Token(Token = "0x400013F")]
	[FieldOffset(Offset = "0x10")]
	private byte[] screenshotData;

	[Token(Token = "0x6000152")]
	[Address(RVA = "0xC167C0", Offset = "0xC167C0", VA = "0xC167C0")]
	public AltUnityScreenshotPNGReadyCommand(byte[] screenshotData)
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0xC167EC", Offset = "0xC167EC", VA = "0xC167EC", Slot = "4")]
	public override string Execute()
	{
		return null;
	}
}
