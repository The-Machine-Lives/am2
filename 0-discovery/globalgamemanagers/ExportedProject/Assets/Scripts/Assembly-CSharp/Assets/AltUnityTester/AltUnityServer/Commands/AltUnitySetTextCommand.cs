using Il2CppDummyDll;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005BA")]
	internal class AltUnitySetTextCommand : AltUnityReflectionMethodsCommand
	{
		[Token(Token = "0x4001AA4")]
		[FieldOffset(Offset = "0x0")]
		private static readonly AltUnityObjectProperty[] TextProperties;

		[Token(Token = "0x4001AA5")]
		[FieldOffset(Offset = "0x10")]
		private AltUnityObject altUnityObject;

		[Token(Token = "0x4001AA6")]
		[FieldOffset(Offset = "0x18")]
		private string inputText;

		[Token(Token = "0x6002B29")]
		[Address(RVA = "0xA35850", Offset = "0xA35850", VA = "0xA35850")]
		public AltUnitySetTextCommand(AltUnityObject altUnityObject, string text)
		{
		}

		[Token(Token = "0x6002B2A")]
		[Address(RVA = "0xA35888", Offset = "0xA35888", VA = "0xA35888", Slot = "4")]
		public override string Execute()
		{
			return null;
		}
	}
}
