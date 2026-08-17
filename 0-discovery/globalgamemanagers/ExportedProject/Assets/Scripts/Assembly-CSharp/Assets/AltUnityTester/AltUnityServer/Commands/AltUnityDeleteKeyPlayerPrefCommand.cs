using Il2CppDummyDll;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005C6")]
	internal class AltUnityDeleteKeyPlayerPrefCommand : AltUnityCommand
	{
		[Token(Token = "0x4001ABA")]
		[FieldOffset(Offset = "0x10")]
		private string keyName;

		[Token(Token = "0x6002B42")]
		[Address(RVA = "0xC146A4", Offset = "0xC146A4", VA = "0xC146A4")]
		public AltUnityDeleteKeyPlayerPrefCommand(string keyName)
		{
		}

		[Token(Token = "0x6002B43")]
		[Address(RVA = "0xC26738", Offset = "0xC26738", VA = "0xC26738", Slot = "4")]
		public override string Execute()
		{
			return null;
		}
	}
}
