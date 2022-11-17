using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace Com.Uken.Analog
{
	[Serializable]
	[Token(Token = "0x2000032")]
	public class EventInfo
	{
		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814BE0", Offset = "0x814BE0")]
		[SerializeField]
		private string type;

		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814C18", Offset = "0x814C18")]
		[SerializeField]
		private string name;

		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "JsonPropertyAttribute", RVA = "0x814C50", Offset = "0x814C50")]
		private EventData data;

		[Token(Token = "0x17000052")]
		[JsonIgnore]
		public string Type
		{
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x16D6018", Offset = "0x16D6018", VA = "0x16D6018")]
			get
			{
				return null;
			}
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x16CDA08", Offset = "0x16CDA08", VA = "0x16CDA08")]
			set
			{
			}
		}

		[Token(Token = "0x17000053")]
		[JsonIgnore]
		public string Name
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x16D6084", Offset = "0x16D6084", VA = "0x16D6084")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x16CDA10", Offset = "0x16CDA10", VA = "0x16CDA10")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		[JsonIgnore]
		public EventData Data
		{
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x16D72B0", Offset = "0x16D72B0", VA = "0x16D72B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x16D72B8", Offset = "0x16D72B8", VA = "0x16D72B8")]
			set
			{
			}
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x16CD9CC", Offset = "0x16CD9CC", VA = "0x16CD9CC")]
		public EventInfo(EventData data)
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x16D72C0", Offset = "0x16D72C0", VA = "0x16D72C0")]
		public bool ContainsKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x16D657C", Offset = "0x16D657C", VA = "0x16D657C")]
		public object GetKey(string key)
		{
			return null;
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x16D64F0", Offset = "0x16D64F0", VA = "0x16D64F0")]
		public void SetData(string key, object value)
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x16D72F4", Offset = "0x16D72F4", VA = "0x16D72F4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
