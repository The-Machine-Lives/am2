using Il2CppDummyDll;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005CC")]
	internal class AltUnitySetTimeScaleCommand : AltUnityCommand
	{
		[Token(Token = "0x4001AC2")]
		[FieldOffset(Offset = "0x10")]
		private float timeScale;

		[Token(Token = "0x6002B4F")]
		[Address(RVA = "0xA35E40", Offset = "0xA35E40", VA = "0xA35E40")]
		public AltUnitySetTimeScaleCommand(float timeScale)
		{
		}

		[Token(Token = "0x6002B50")]
		[Address(RVA = "0xA35E74", Offset = "0xA35E74", VA = "0xA35E74", Slot = "4")]
		public override string Execute()
		{
			return null;
		}
	}
}
