using Il2CppDummyDll;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005A1")]
	internal class AltUnityGetAllCamerasCommand : AltUnityCommand
	{
		[Token(Token = "0x6002AF5")]
		[Address(RVA = "0xC29B98", Offset = "0xC29B98", VA = "0xC29B98", Slot = "4")]
		public override string Execute()
		{
			return null;
		}

		[Token(Token = "0x6002AF6")]
		[Address(RVA = "0xC147C0", Offset = "0xC147C0", VA = "0xC147C0")]
		public AltUnityGetAllCamerasCommand()
		{
		}
	}
}
