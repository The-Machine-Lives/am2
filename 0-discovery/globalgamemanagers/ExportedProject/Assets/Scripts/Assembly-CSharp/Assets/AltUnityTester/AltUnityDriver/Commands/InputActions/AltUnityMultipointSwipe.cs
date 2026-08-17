using Assets.AltUnityTester.AltUnityDriver.UnityStruct;
using Il2CppDummyDll;

namespace Assets.AltUnityTester.AltUnityDriver.Commands.InputActions
{
	[Token(Token = "0x20005E1")]
	public class AltUnityMultipointSwipe : AltBaseCommand
	{
		[Token(Token = "0x4001C4C")]
		[FieldOffset(Offset = "0x38")]
		private AltUnityVector2[] positions;

		[Token(Token = "0x4001C4D")]
		[FieldOffset(Offset = "0x40")]
		private float duration;

		[Token(Token = "0x6002B74")]
		[Address(RVA = "0xC1DDC8", Offset = "0xC1DDC8", VA = "0xC1DDC8")]
		public AltUnityMultipointSwipe(SocketSettings socketSettings, AltUnityVector2[] positions, float duration)
		{
		}

		[Token(Token = "0x6002B75")]
		[Address(RVA = "0xC1DE7C", Offset = "0xC1DE7C", VA = "0xC1DE7C")]
		public void Execute()
		{
		}
	}
}
