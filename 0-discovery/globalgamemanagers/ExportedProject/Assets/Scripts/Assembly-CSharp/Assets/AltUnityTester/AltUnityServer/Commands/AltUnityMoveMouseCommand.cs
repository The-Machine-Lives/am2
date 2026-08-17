using Il2CppDummyDll;
using UnityEngine;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005A9")]
	internal class AltUnityMoveMouseCommand : AltUnityCommand
	{
		[Token(Token = "0x4001A85")]
		[FieldOffset(Offset = "0x10")]
		private Vector2 location;

		[Token(Token = "0x4001A86")]
		[FieldOffset(Offset = "0x18")]
		private float duration;

		[Token(Token = "0x6002B05")]
		[Address(RVA = "0xC14904", Offset = "0xC14904", VA = "0xC14904")]
		public AltUnityMoveMouseCommand(Vector2 location, float duration)
		{
		}

		[Token(Token = "0x6002B06")]
		[Address(RVA = "0xC2C4B4", Offset = "0xC2C4B4", VA = "0xC2C4B4", Slot = "4")]
		public override string Execute()
		{
			return null;
		}
	}
}
