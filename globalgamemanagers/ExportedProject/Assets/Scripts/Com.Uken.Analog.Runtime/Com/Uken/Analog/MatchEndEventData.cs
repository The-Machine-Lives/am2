using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x200004A")]
	public class MatchEndEventData : EventData
	{
		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x18")]
		private Guid matchId;

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x16D9FE8", Offset = "0x16D9FE8", VA = "0x16D9FE8")]
		public MatchEndEventData(Guid matchId)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x16DA028", Offset = "0x16DA028", VA = "0x16DA028", Slot = "4")]
		public override void SerializeJson(JsonWriter writer)
		{
		}
	}
}
