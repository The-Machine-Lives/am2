using Il2CppDummyDll;
using UnityEngine;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005AF")]
	internal class AltUnitySetMultipointSwipeCommand : AltUnityCommand
	{
		[Token(Token = "0x4001A8D")]
		[FieldOffset(Offset = "0x10")]
		private Vector2 start;

		[Token(Token = "0x4001A8E")]
		[FieldOffset(Offset = "0x18")]
		private Vector2 destination;

		[Token(Token = "0x4001A8F")]
		[FieldOffset(Offset = "0x20")]
		private string duration;

		[Token(Token = "0x6002B11")]
		[Address(RVA = "0xA35428", Offset = "0xA35428", VA = "0xA35428")]
		public AltUnitySetMultipointSwipeCommand(Vector2 start, Vector2 destination, string duration)
		{
		}

		[Token(Token = "0x6002B12")]
		[Address(RVA = "0xA3547C", Offset = "0xA3547C", VA = "0xA3547C", Slot = "4")]
		public override string Execute()
		{
			return null;
		}
	}
}
