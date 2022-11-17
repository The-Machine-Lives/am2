using Il2CppDummyDll;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x200059B")]
	internal class AltUnityGetServerVersionCommand : AltUnityCommand
	{
		[Token(Token = "0x6002AE9")]
		[Address(RVA = "0xC2AD10", Offset = "0xC2AD10", VA = "0xC2AD10", Slot = "4")]
		public override string Execute()
		{
			return null;
		}

		[Token(Token = "0x6002AEA")]
		[Address(RVA = "0xC14A58", Offset = "0xC14A58", VA = "0xC14A58")]
		public AltUnityGetServerVersionCommand()
		{
		}
	}
}
