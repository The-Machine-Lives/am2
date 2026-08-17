using Il2CppDummyDll;
using UnityEngine;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005C1")]
	internal class AltUnityGetScreenshotCommand : AltUnityCommand
	{
		[Token(Token = "0x4001AAD")]
		[FieldOffset(Offset = "0x10")]
		private Vector2 size;

		[Token(Token = "0x4001AAE")]
		[FieldOffset(Offset = "0x18")]
		private AltClientSocketHandler handler;

		[Token(Token = "0x6002B38")]
		[Address(RVA = "0xC147C8", Offset = "0xC147C8", VA = "0xC147C8")]
		public AltUnityGetScreenshotCommand(Vector2 size, AltClientSocketHandler handler)
		{
		}

		[Token(Token = "0x6002B39")]
		[Address(RVA = "0xC2AAD8", Offset = "0xC2AAD8", VA = "0xC2AAD8", Slot = "4")]
		public override string Execute()
		{
			return null;
		}
	}
}
