using Il2CppDummyDll;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005B8")]
	internal class AltUnityGetTextCommand : AltUnityReflectionMethodsCommand
	{
		[Token(Token = "0x4001A9F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly AltUnityObjectProperty[] TextProperties;

		[Token(Token = "0x4001AA0")]
		[FieldOffset(Offset = "0x10")]
		private AltUnityObject altUnityObject;

		[Token(Token = "0x6002B24")]
		[Address(RVA = "0xC14A00", Offset = "0xC14A00", VA = "0xC14A00")]
		public AltUnityGetTextCommand(AltUnityObject altUnityObject)
		{
		}

		[Token(Token = "0x6002B25")]
		[Address(RVA = "0xC2ADC0", Offset = "0xC2ADC0", VA = "0xC2ADC0", Slot = "4")]
		public override string Execute()
		{
			return null;
		}
	}
}
