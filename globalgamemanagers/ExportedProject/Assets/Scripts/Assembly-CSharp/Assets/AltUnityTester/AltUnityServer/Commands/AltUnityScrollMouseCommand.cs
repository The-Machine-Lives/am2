using Il2CppDummyDll;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005AE")]
	internal class AltUnityScrollMouseCommand : AltUnityCommand
	{
		[Token(Token = "0x4001A8B")]
		[FieldOffset(Offset = "0x10")]
		private float scrollValue;

		[Token(Token = "0x4001A8C")]
		[FieldOffset(Offset = "0x14")]
		private float duration;

		[Token(Token = "0x6002B0F")]
		[Address(RVA = "0xA3515C", Offset = "0xA3515C", VA = "0xA3515C")]
		public AltUnityScrollMouseCommand(float scrollValue, float duration)
		{
		}

		[Token(Token = "0x6002B10")]
		[Address(RVA = "0xA35194", Offset = "0xA35194", VA = "0xA35194", Slot = "4")]
		public override string Execute()
		{
			return null;
		}
	}
}
