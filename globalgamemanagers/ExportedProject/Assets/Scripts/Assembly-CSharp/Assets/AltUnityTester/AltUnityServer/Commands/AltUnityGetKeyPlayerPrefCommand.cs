using Il2CppDummyDll;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005C8")]
	internal class AltUnityGetKeyPlayerPrefCommand : AltUnityCommand
	{
		[Token(Token = "0x4001ABB")]
		[FieldOffset(Offset = "0x10")]
		private PLayerPrefKeyType type;

		[Token(Token = "0x4001ABC")]
		[FieldOffset(Offset = "0x18")]
		private string value;

		[Token(Token = "0x6002B46")]
		[Address(RVA = "0xC146D0", Offset = "0xC146D0", VA = "0xC146D0")]
		public AltUnityGetKeyPlayerPrefCommand(PLayerPrefKeyType type, string value)
		{
		}

		[Token(Token = "0x6002B47")]
		[Address(RVA = "0xC2A80C", Offset = "0xC2A80C", VA = "0xC2A80C", Slot = "4")]
		public override string Execute()
		{
			return null;
		}
	}
}
