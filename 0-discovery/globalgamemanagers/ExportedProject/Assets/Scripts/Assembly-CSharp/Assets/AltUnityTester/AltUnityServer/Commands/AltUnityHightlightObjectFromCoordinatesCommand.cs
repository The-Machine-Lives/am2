using Il2CppDummyDll;
using UnityEngine;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005C4")]
	internal class AltUnityHightlightObjectFromCoordinatesCommand : AltUnityCommand
	{
		[Token(Token = "0x4001AB4")]
		[FieldOffset(Offset = "0x10")]
		private Vector2 screenCoordinates;

		[Token(Token = "0x4001AB5")]
		[FieldOffset(Offset = "0x18")]
		private string ColorAndWidth;

		[Token(Token = "0x4001AB6")]
		[FieldOffset(Offset = "0x20")]
		private Vector2 size;

		[Token(Token = "0x4001AB7")]
		[FieldOffset(Offset = "0x28")]
		private AltClientSocketHandler handler;

		[Token(Token = "0x6002B3E")]
		[Address(RVA = "0xC14860", Offset = "0xC14860", VA = "0xC14860")]
		public AltUnityHightlightObjectFromCoordinatesCommand(Vector2 screenCoordinates, string colorAndWidth, Vector2 size, AltClientSocketHandler handler)
		{
		}

		[Token(Token = "0x6002B3F")]
		[Address(RVA = "0xC2B7A0", Offset = "0xC2B7A0", VA = "0xC2B7A0", Slot = "4")]
		public override string Execute()
		{
			return null;
		}
	}
}
