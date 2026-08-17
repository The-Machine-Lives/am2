using Il2CppDummyDll;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005AA")]
	internal class AltUnityPointerDownFromObjectCommand : AltUnityCommand
	{
		[Token(Token = "0x4001A87")]
		[FieldOffset(Offset = "0x10")]
		private AltUnityObject altUnityObject;

		[Token(Token = "0x6002B07")]
		[Address(RVA = "0xC14604", Offset = "0xC14604", VA = "0xC14604")]
		public AltUnityPointerDownFromObjectCommand(AltUnityObject altUnityObject)
		{
		}

		[Token(Token = "0x6002B08")]
		[Address(RVA = "0xC2C4BC", Offset = "0xC2C4BC", VA = "0xC2C4BC", Slot = "4")]
		public override string Execute()
		{
			return null;
		}
	}
}
