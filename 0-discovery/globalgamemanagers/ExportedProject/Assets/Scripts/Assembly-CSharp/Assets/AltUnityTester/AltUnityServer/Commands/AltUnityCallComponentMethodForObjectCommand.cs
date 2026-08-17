using Il2CppDummyDll;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005B3")]
	internal class AltUnityCallComponentMethodForObjectCommand : AltUnityReflectionMethodsCommand
	{
		[Token(Token = "0x4001A96")]
		[FieldOffset(Offset = "0x10")]
		private string altObjectString;

		[Token(Token = "0x4001A97")]
		[FieldOffset(Offset = "0x18")]
		private string actionString;

		[Token(Token = "0x6002B1A")]
		[Address(RVA = "0xC1449C", Offset = "0xC1449C", VA = "0xC1449C")]
		public AltUnityCallComponentMethodForObjectCommand(string altObjectString, string actionString)
		{
		}

		[Token(Token = "0x6002B1B")]
		[Address(RVA = "0xC25B74", Offset = "0xC25B74", VA = "0xC25B74", Slot = "4")]
		public override string Execute()
		{
			return null;
		}
	}
}
