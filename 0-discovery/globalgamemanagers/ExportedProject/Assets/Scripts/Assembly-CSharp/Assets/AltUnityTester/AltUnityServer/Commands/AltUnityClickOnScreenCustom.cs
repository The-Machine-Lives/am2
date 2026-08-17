using Il2CppDummyDll;
using UnityEngine;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005A5")]
	public class AltUnityClickOnScreenCustom : AltUnityCommand
	{
		[Token(Token = "0x4001A7B")]
		[FieldOffset(Offset = "0x10")]
		private Vector2 position;

		[Token(Token = "0x4001A7C")]
		[FieldOffset(Offset = "0x18")]
		private string count;

		[Token(Token = "0x4001A7D")]
		[FieldOffset(Offset = "0x20")]
		private string interval;

		[Token(Token = "0x6002AFD")]
		[Address(RVA = "0xC14538", Offset = "0xC14538", VA = "0xC14538")]
		public AltUnityClickOnScreenCustom(Vector2 position, string count, string interval)
		{
		}

		[Token(Token = "0x6002AFE")]
		[Address(RVA = "0xC26730", Offset = "0xC26730", VA = "0xC26730", Slot = "4")]
		public override string Execute()
		{
			return null;
		}
	}
}
