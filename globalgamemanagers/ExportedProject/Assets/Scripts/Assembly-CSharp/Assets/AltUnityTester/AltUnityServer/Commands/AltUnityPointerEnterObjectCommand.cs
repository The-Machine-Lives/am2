using Il2CppDummyDll;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005AB")]
	internal class AltUnityPointerEnterObjectCommand : AltUnityCommand
	{
		[Token(Token = "0x4001A88")]
		[FieldOffset(Offset = "0x10")]
		private AltUnityObject altUnityObject;

		[Token(Token = "0x6002B09")]
		[Address(RVA = "0xC14630", Offset = "0xC14630", VA = "0xC14630")]
		public AltUnityPointerEnterObjectCommand(AltUnityObject altUnityObject)
		{
		}

		[Token(Token = "0x6002B0A")]
		[Address(RVA = "0xC2C788", Offset = "0xC2C788", VA = "0xC2C788", Slot = "4")]
		public override string Execute()
		{
			return null;
		}
	}
}
