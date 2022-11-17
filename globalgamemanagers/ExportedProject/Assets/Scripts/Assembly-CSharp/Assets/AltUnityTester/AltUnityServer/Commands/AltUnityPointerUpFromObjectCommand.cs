using Il2CppDummyDll;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005AD")]
	internal class AltUnityPointerUpFromObjectCommand : AltUnityCommand
	{
		[Token(Token = "0x4001A8A")]
		[FieldOffset(Offset = "0x10")]
		private AltUnityObject altUnityObject;

		[Token(Token = "0x6002B0D")]
		[Address(RVA = "0xA34538", Offset = "0xA34538", VA = "0xA34538")]
		public AltUnityPointerUpFromObjectCommand(AltUnityObject altUnityObject)
		{
		}

		[Token(Token = "0x6002B0E")]
		[Address(RVA = "0xA34564", Offset = "0xA34564", VA = "0xA34564", Slot = "4")]
		public override string Execute()
		{
			return null;
		}
	}
}
