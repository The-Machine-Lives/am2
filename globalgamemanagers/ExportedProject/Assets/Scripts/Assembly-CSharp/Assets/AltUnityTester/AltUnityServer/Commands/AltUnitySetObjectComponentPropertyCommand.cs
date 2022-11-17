using Il2CppDummyDll;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005B9")]
	internal class AltUnitySetObjectComponentPropertyCommand : AltUnityReflectionMethodsCommand
	{
		[Token(Token = "0x4001AA1")]
		[FieldOffset(Offset = "0x10")]
		private string altObjectString;

		[Token(Token = "0x4001AA2")]
		[FieldOffset(Offset = "0x18")]
		private string propertyString;

		[Token(Token = "0x4001AA3")]
		[FieldOffset(Offset = "0x20")]
		private string valueString;

		[Token(Token = "0x6002B27")]
		[Address(RVA = "0xA35484", Offset = "0xA35484", VA = "0xA35484")]
		public AltUnitySetObjectComponentPropertyCommand(string altObjectString, string propertyString, string valueString)
		{
		}

		[Token(Token = "0x6002B28")]
		[Address(RVA = "0xA354C4", Offset = "0xA354C4", VA = "0xA354C4", Slot = "4")]
		public override string Execute()
		{
			return null;
		}
	}
}
