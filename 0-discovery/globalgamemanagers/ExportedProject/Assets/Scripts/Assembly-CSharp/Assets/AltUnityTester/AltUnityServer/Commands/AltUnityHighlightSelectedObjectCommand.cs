using Il2CppDummyDll;
using UnityEngine;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005C3")]
	internal class AltUnityHighlightSelectedObjectCommand : AltUnityCommand
	{
		[Token(Token = "0x4001AB0")]
		[FieldOffset(Offset = "0x10")]
		private int id;

		[Token(Token = "0x4001AB1")]
		[FieldOffset(Offset = "0x18")]
		private string ColorAndWidth;

		[Token(Token = "0x4001AB2")]
		[FieldOffset(Offset = "0x20")]
		private Vector2 size;

		[Token(Token = "0x4001AB3")]
		[FieldOffset(Offset = "0x28")]
		private AltClientSocketHandler handler;

		[Token(Token = "0x6002B3C")]
		[Address(RVA = "0xC14808", Offset = "0xC14808", VA = "0xC14808")]
		public AltUnityHighlightSelectedObjectCommand(int id, string colorAndWidth, Vector2 size, AltClientSocketHandler handler)
		{
		}

		[Token(Token = "0x6002B3D")]
		[Address(RVA = "0xC2B33C", Offset = "0xC2B33C", VA = "0xC2B33C", Slot = "4")]
		public override string Execute()
		{
			return null;
		}
	}
}
