using Il2CppDummyDll;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005AC")]
	internal class AltUnityPointerExitObjectCommand : AltUnityCommand
	{
		[Token(Token = "0x4001A89")]
		[FieldOffset(Offset = "0x10")]
		private AltUnityObject altUnityObject;

		[Token(Token = "0x6002B0B")]
		[Address(RVA = "0xA3422C", Offset = "0xA3422C", VA = "0xA3422C")]
		public AltUnityPointerExitObjectCommand(AltUnityObject altUnityObject)
		{
		}

		[Token(Token = "0x6002B0C")]
		[Address(RVA = "0xA34258", Offset = "0xA34258", VA = "0xA34258", Slot = "4")]
		public override string Execute()
		{
			return null;
		}
	}
}
