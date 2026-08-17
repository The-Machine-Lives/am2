using Il2CppDummyDll;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005C7")]
	internal class AltUnityDeletePlayerPrefCommand : AltUnityCommand
	{
		[Token(Token = "0x6002B44")]
		[Address(RVA = "0xC26810", Offset = "0xC26810", VA = "0xC26810", Slot = "4")]
		public override string Execute()
		{
			return null;
		}

		[Token(Token = "0x6002B45")]
		[Address(RVA = "0xC1469C", Offset = "0xC1469C", VA = "0xC1469C")]
		public AltUnityDeletePlayerPrefCommand()
		{
		}
	}
}
