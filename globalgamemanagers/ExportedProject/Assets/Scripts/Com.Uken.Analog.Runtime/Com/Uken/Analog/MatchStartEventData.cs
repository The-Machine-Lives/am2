using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x200004C")]
	public class MatchStartEventData : EventData
	{
		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x18")]
		private Guid matchId;

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x16DA1A8", Offset = "0x16DA1A8", VA = "0x16DA1A8")]
		public MatchStartEventData(Guid matchId)
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x16DA1E8", Offset = "0x16DA1E8", VA = "0x16DA1E8", Slot = "4")]
		public override void SerializeJson(JsonWriter writer)
		{
		}
	}
}
