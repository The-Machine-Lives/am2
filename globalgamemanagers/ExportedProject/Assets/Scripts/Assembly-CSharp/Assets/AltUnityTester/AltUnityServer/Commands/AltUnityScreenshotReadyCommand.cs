using Il2CppDummyDll;
using UnityEngine;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005C5")]
	internal class AltUnityScreenshotReadyCommand : AltUnityCommand
	{
		[Token(Token = "0x4001AB8")]
		[FieldOffset(Offset = "0x10")]
		private Texture2D screenshot;

		[Token(Token = "0x4001AB9")]
		[FieldOffset(Offset = "0x18")]
		private Vector2 size;

		[Token(Token = "0x6002B40")]
		[Address(RVA = "0xA34844", Offset = "0xA34844", VA = "0xA34844")]
		public AltUnityScreenshotReadyCommand(Texture2D screenshot, Vector2 size)
		{
		}

		[Token(Token = "0x6002B41")]
		[Address(RVA = "0xA34884", Offset = "0xA34884", VA = "0xA34884", Slot = "4")]
		public override string Execute()
		{
			return null;
		}
	}
}
