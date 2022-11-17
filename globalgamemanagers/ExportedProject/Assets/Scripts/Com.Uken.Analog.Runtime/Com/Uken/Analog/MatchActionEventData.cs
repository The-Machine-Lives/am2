using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x2000048")]
	public class MatchActionEventData : EventData
	{
		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x18")]
		private Guid matchId;

		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x28")]
		private string actionName;

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x16D9DB4", Offset = "0x16D9DB4", VA = "0x16D9DB4")]
		public MatchActionEventData(Guid matchId, string actionName)
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x16D9DFC", Offset = "0x16D9DFC", VA = "0x16D9DFC", Slot = "4")]
		public override void SerializeJson(JsonWriter writer)
		{
		}
	}
}
