using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x2000030")]
	[AttributeAttribute(Name = "JsonConverterAttribute", RVA = "0x813D34", Offset = "0x813D34")]
	public class EventData
	{
		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, object> opaqueData;

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x16CDD74", Offset = "0x16CDD74", VA = "0x16CDD74", Slot = "4")]
		public virtual void SerializeJson(JsonWriter writer)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x16D6E74", Offset = "0x16D6E74", VA = "0x16D6E74")]
		public bool ContainsKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x16D6EE8", Offset = "0x16D6EE8", VA = "0x16D6EE8")]
		public object Get(string key)
		{
			return null;
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x16D6F8C", Offset = "0x16D6F8C", VA = "0x16D6F8C")]
		public void Add(string key, object value)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x16CDA18", Offset = "0x16CDA18", VA = "0x16CDA18")]
		public EventData()
		{
		}
	}
}
