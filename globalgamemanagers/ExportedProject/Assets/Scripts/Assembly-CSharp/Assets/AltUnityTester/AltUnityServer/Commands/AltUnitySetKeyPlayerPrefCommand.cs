using Il2CppDummyDll;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005CB")]
	internal class AltUnitySetKeyPlayerPrefCommand : AltUnityCommand
	{
		[Token(Token = "0x4001ABF")]
		[FieldOffset(Offset = "0x10")]
		private PLayerPrefKeyType type;

		[Token(Token = "0x4001AC0")]
		[FieldOffset(Offset = "0x18")]
		private string keyName;

		[Token(Token = "0x4001AC1")]
		[FieldOffset(Offset = "0x20")]
		private string value;

		[Token(Token = "0x6002B4D")]
		[Address(RVA = "0xA3519C", Offset = "0xA3519C", VA = "0xA3519C")]
		public AltUnitySetKeyPlayerPrefCommand(PLayerPrefKeyType type, string keyName, string value)
		{
		}

		[Token(Token = "0x6002B4E")]
		[Address(RVA = "0xA351DC", Offset = "0xA351DC", VA = "0xA351DC", Slot = "4")]
		public override string Execute()
		{
			return null;
		}
	}
}
