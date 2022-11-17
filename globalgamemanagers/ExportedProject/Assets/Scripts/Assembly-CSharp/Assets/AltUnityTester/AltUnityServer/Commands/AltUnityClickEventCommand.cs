using Il2CppDummyDll;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005A3")]
	internal class AltUnityClickEventCommand : AltUnityCommand
	{
		[Token(Token = "0x4001A78")]
		[FieldOffset(Offset = "0x10")]
		private AltUnityObject altUnityObject;

		[Token(Token = "0x6002AF9")]
		[Address(RVA = "0xC144D4", Offset = "0xC144D4", VA = "0xC144D4")]
		public AltUnityClickEventCommand(AltUnityObject altObject)
		{
		}

		[Token(Token = "0x6002AFA")]
		[Address(RVA = "0xC25EC8", Offset = "0xC25EC8", VA = "0xC25EC8", Slot = "4")]
		public override string Execute()
		{
			return null;
		}
	}
}
