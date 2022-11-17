using Il2CppDummyDll;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005B7")]
	internal class AltUnityGetComponentPropertyCommand : AltUnityReflectionMethodsCommand
	{
		[Token(Token = "0x4001A9D")]
		[FieldOffset(Offset = "0x10")]
		private string altObjectString;

		[Token(Token = "0x4001A9E")]
		[FieldOffset(Offset = "0x18")]
		private string propertyString;

		[Token(Token = "0x6002B22")]
		[Address(RVA = "0xC14464", Offset = "0xC14464", VA = "0xC14464")]
		public AltUnityGetComponentPropertyCommand(string altObjectString, string propertyString)
		{
		}

		[Token(Token = "0x6002B23")]
		[Address(RVA = "0xC2A684", Offset = "0xC2A684", VA = "0xC2A684", Slot = "4")]
		public override string Execute()
		{
			return null;
		}
	}
}
