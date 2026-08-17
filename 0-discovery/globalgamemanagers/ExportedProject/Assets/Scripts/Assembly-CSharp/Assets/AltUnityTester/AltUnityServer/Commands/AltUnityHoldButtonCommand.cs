using Il2CppDummyDll;
using UnityEngine;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005A8")]
	internal class AltUnityHoldButtonCommand : AltUnityCommand
	{
		[Token(Token = "0x4001A82")]
		[FieldOffset(Offset = "0x10")]
		private KeyCode keyCode;

		[Token(Token = "0x4001A83")]
		[FieldOffset(Offset = "0x14")]
		private float power;

		[Token(Token = "0x4001A84")]
		[FieldOffset(Offset = "0x18")]
		private float duration;

		[Token(Token = "0x6002B03")]
		[Address(RVA = "0xC148C4", Offset = "0xC148C4", VA = "0xC148C4")]
		public AltUnityHoldButtonCommand(KeyCode keyCode, float power, float duration)
		{
		}

		[Token(Token = "0x6002B04")]
		[Address(RVA = "0xC2C29C", Offset = "0xC2C29C", VA = "0xC2C29C", Slot = "4")]
		public override string Execute()
		{
			return null;
		}
	}
}
