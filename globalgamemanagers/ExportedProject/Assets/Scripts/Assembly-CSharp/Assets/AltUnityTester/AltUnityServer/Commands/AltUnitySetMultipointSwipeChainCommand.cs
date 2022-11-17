using Il2CppDummyDll;
using UnityEngine;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005B0")]
	public class AltUnitySetMultipointSwipeChainCommand : AltUnityCommand
	{
		[Token(Token = "0x4001A90")]
		[FieldOffset(Offset = "0x10")]
		private Vector2[] positions;

		[Token(Token = "0x4001A91")]
		[FieldOffset(Offset = "0x18")]
		private string duration;

		[Token(Token = "0x6002B13")]
		[Address(RVA = "0xA353E8", Offset = "0xA353E8", VA = "0xA353E8")]
		public AltUnitySetMultipointSwipeChainCommand(Vector2[] positions, string duration)
		{
		}

		[Token(Token = "0x6002B14")]
		[Address(RVA = "0xA35420", Offset = "0xA35420", VA = "0xA35420", Slot = "4")]
		public override string Execute()
		{
			return null;
		}
	}
}
