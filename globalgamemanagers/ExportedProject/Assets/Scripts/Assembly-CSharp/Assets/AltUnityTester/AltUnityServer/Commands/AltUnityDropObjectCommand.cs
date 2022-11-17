using Il2CppDummyDll;
using UnityEngine;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005A7")]
	internal class AltUnityDropObjectCommand : AltUnityCommand
	{
		[Token(Token = "0x4001A80")]
		[FieldOffset(Offset = "0x10")]
		private Vector2 position;

		[Token(Token = "0x4001A81")]
		[FieldOffset(Offset = "0x18")]
		private AltUnityObject altUnityObject;

		[Token(Token = "0x6002B01")]
		[Address(RVA = "0xC145C4", Offset = "0xC145C4", VA = "0xC145C4")]
		public AltUnityDropObjectCommand(Vector2 position, AltUnityObject altUnityObject)
		{
		}

		[Token(Token = "0x6002B02")]
		[Address(RVA = "0xC26D24", Offset = "0xC26D24", VA = "0xC26D24", Slot = "4")]
		public override string Execute()
		{
			return null;
		}
	}
}
