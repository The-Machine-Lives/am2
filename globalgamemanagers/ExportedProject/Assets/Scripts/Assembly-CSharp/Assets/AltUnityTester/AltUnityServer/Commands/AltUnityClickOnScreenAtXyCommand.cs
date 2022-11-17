using Il2CppDummyDll;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005A4")]
	internal class AltUnityClickOnScreenAtXyCommand : AltUnityCommand
	{
		[Token(Token = "0x4001A79")]
		[FieldOffset(Offset = "0x10")]
		private string x;

		[Token(Token = "0x4001A7A")]
		[FieldOffset(Offset = "0x18")]
		private string y;

		[Token(Token = "0x6002AFB")]
		[Address(RVA = "0xC14500", Offset = "0xC14500", VA = "0xC14500")]
		public AltUnityClickOnScreenAtXyCommand(string x, string y)
		{
		}

		[Token(Token = "0x6002AFC")]
		[Address(RVA = "0xC26104", Offset = "0xC26104", VA = "0xC26104", Slot = "4")]
		public override string Execute()
		{
			return null;
		}
	}
}
