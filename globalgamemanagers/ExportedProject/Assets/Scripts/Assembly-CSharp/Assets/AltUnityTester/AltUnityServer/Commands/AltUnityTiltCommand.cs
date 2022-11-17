using Il2CppDummyDll;
using UnityEngine;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005B2")]
	internal class AltUnityTiltCommand : AltUnityCommand
	{
		[Token(Token = "0x4001A94")]
		[FieldOffset(Offset = "0x10")]
		private Vector3 acceleration;

		[Token(Token = "0x4001A95")]
		[FieldOffset(Offset = "0x1C")]
		private float duration;

		[Token(Token = "0x6002B18")]
		[Address(RVA = "0xA36584", Offset = "0xA36584", VA = "0xA36584")]
		public AltUnityTiltCommand(Vector3 acceleration, float duration)
		{
		}

		[Token(Token = "0x6002B19")]
		[Address(RVA = "0xA365D0", Offset = "0xA365D0", VA = "0xA365D0", Slot = "4")]
		public override string Execute()
		{
			return null;
		}
	}
}
