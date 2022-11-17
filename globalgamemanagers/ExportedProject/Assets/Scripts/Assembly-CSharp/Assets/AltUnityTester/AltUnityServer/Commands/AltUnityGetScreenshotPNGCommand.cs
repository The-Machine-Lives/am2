using Il2CppDummyDll;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005C2")]
	internal class AltUnityGetScreenshotPNGCommand : AltUnityCommand
	{
		[Token(Token = "0x4001AAF")]
		[FieldOffset(Offset = "0x10")]
		private AltClientSocketHandler handler;

		[Token(Token = "0x6002B3A")]
		[Address(RVA = "0xC14A2C", Offset = "0xC14A2C", VA = "0xC14A2C")]
		public AltUnityGetScreenshotPNGCommand(AltClientSocketHandler handler)
		{
		}

		[Token(Token = "0x6002B3B")]
		[Address(RVA = "0xC2AC20", Offset = "0xC2AC20", VA = "0xC2AC20", Slot = "4")]
		public override string Execute()
		{
			return null;
		}
	}
}
