using Il2CppDummyDll;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x200059A")]
	internal class AltUnityEnableLoggingCommand : AltUnityCommand
	{
		[Token(Token = "0x4001A73")]
		[FieldOffset(Offset = "0x10")]
		private bool activateDebug;

		[Token(Token = "0x6002AE7")]
		[Address(RVA = "0xC149D0", Offset = "0xC149D0", VA = "0xC149D0")]
		public AltUnityEnableLoggingCommand(bool activateDebug)
		{
		}

		[Token(Token = "0x6002AE8")]
		[Address(RVA = "0xC26FEC", Offset = "0xC26FEC", VA = "0xC26FEC", Slot = "4")]
		public override string Execute()
		{
			return null;
		}
	}
}
