using Il2CppDummyDll;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005A2")]
	internal class AltUnityActionFinishedCommand : AltUnityCommand
	{
		[Token(Token = "0x6002AF7")]
		[Address(RVA = "0xC25AFC", Offset = "0xC25AFC", VA = "0xC25AFC", Slot = "4")]
		public override string Execute()
		{
			return null;
		}

		[Token(Token = "0x6002AF8")]
		[Address(RVA = "0xC1470C", Offset = "0xC1470C", VA = "0xC1470C")]
		public AltUnityActionFinishedCommand()
		{
		}
	}
}
