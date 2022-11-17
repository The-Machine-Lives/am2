using Assets.AltUnityTester.AltUnityDriver.UnityStruct;
using Il2CppDummyDll;

namespace Assets.AltUnityTester.AltUnityDriver.Commands.InputActions
{
	[Token(Token = "0x20005E2")]
	public class AltUnityMultipointSwipeAndWait : AltBaseCommand
	{
		[Token(Token = "0x4001C4E")]
		[FieldOffset(Offset = "0x38")]
		private AltUnityVector2[] positions;

		[Token(Token = "0x4001C4F")]
		[FieldOffset(Offset = "0x40")]
		private float duration;

		[Token(Token = "0x6002B76")]
		[Address(RVA = "0xC1E0B0", Offset = "0xC1E0B0", VA = "0xC1E0B0")]
		public AltUnityMultipointSwipeAndWait(SocketSettings socketSettings, AltUnityVector2[] positions, float duration)
		{
		}

		[Token(Token = "0x6002B77")]
		[Address(RVA = "0xC1E164", Offset = "0xC1E164", VA = "0xC1E164")]
		public void Execute()
		{
		}
	}
}
