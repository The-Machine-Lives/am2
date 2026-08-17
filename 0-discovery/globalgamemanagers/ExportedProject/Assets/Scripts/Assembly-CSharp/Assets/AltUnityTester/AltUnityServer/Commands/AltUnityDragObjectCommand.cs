using Il2CppDummyDll;
using UnityEngine;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005A6")]
	internal class AltUnityDragObjectCommand : AltUnityCommand
	{
		[Token(Token = "0x4001A7E")]
		[FieldOffset(Offset = "0x10")]
		private Vector2 position;

		[Token(Token = "0x4001A7F")]
		[FieldOffset(Offset = "0x18")]
		private AltUnityObject altUnityObject;

		[Token(Token = "0x6002AFF")]
		[Address(RVA = "0xC14584", Offset = "0xC14584", VA = "0xC14584")]
		public AltUnityDragObjectCommand(Vector2 position, AltUnityObject altUnityObject)
		{
		}

		[Token(Token = "0x6002B00")]
		[Address(RVA = "0xC268C4", Offset = "0xC268C4", VA = "0xC268C4", Slot = "4")]
		public override string Execute()
		{
			return null;
		}
	}
}
