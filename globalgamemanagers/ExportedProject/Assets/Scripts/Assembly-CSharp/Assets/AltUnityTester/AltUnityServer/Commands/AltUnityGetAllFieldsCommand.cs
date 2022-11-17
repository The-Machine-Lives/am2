using Il2CppDummyDll;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005B5")]
	internal class AltUnityGetAllFieldsCommand : AltUnityReflectionMethodsCommand
	{
		[Token(Token = "0x4001A99")]
		[FieldOffset(Offset = "0x10")]
		private string id;

		[Token(Token = "0x4001A9A")]
		[FieldOffset(Offset = "0x18")]
		private AltUnityComponent component;

		[Token(Token = "0x6002B1E")]
		[Address(RVA = "0xC14740", Offset = "0xC14740", VA = "0xC14740")]
		public AltUnityGetAllFieldsCommand(string id, AltUnityComponent component)
		{
		}

		[Token(Token = "0x6002B1F")]
		[Address(RVA = "0xC2A150", Offset = "0xC2A150", VA = "0xC2A150", Slot = "4")]
		public override string Execute()
		{
			return null;
		}
	}
}
