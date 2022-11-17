using Il2CppDummyDll;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x200059C")]
	internal class AltUnityUnknowStringCommand : AltUnityCommand
	{
		[Token(Token = "0x6002AEB")]
		[Address(RVA = "0xA365D8", Offset = "0xA365D8", VA = "0xA365D8", Slot = "4")]
		public override string Execute()
		{
			return null;
		}

		[Token(Token = "0x6002AEC")]
		[Address(RVA = "0xA36650", Offset = "0xA36650", VA = "0xA36650")]
		public AltUnityUnknowStringCommand()
		{
		}
	}
}
