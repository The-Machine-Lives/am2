using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x2000016")]
	public class ABAssignmentEventData : EventData
	{
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x18")]
		private List<Assignment> assignments;

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x16CD9A0", Offset = "0x16CD9A0", VA = "0x16CD9A0")]
		public ABAssignmentEventData(List<Assignment> assignments)
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x16CDA20", Offset = "0x16CDA20", VA = "0x16CDA20", Slot = "4")]
		public override void SerializeJson(JsonWriter writer)
		{
		}
	}
}
