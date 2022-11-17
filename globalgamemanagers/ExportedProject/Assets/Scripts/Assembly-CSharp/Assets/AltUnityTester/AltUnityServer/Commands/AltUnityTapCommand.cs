using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.AltUnityTester.AltUnityServer.Commands
{
	[Token(Token = "0x20005B1")]
	internal class AltUnityTapCommand : AltUnityCommand
	{
		[Token(Token = "0x4001A92")]
		[FieldOffset(Offset = "0x10")]
		private AltUnityObject altUnityObject;

		[Token(Token = "0x4001A93")]
		[FieldOffset(Offset = "0x18")]
		private int count;

		[Token(Token = "0x6002B15")]
		[Address(RVA = "0xA35F78", Offset = "0xA35F78", VA = "0xA35F78")]
		public AltUnityTapCommand(AltUnityObject altUnityObject, int count)
		{
		}

		[Token(Token = "0x6002B16")]
		[Address(RVA = "0xA35FB4", Offset = "0xA35FB4", VA = "0xA35FB4", Slot = "4")]
		public override string Execute()
		{
			return null;
		}

		[Token(Token = "0x6002B17")]
		[Address(RVA = "0xA3636C", Offset = "0xA3636C", VA = "0xA3636C")]
		private void InitiateClick(GameObject gameObject, PointerEventData pointerEventData)
		{
		}
	}
}
